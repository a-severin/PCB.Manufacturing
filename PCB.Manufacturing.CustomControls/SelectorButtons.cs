using System;
using System.Windows;
using System.Windows.Controls;
using PCB.Manufacturing.Framework;

namespace PCB.Manufacturing.CustomControls
{
    [TemplatePart(Name = nameof(ButtonsGrid), Type = typeof(Grid))]
    public class SelectorButtons : Control
    {
        public static readonly DependencyProperty CornerRadiusProperty
            = DependencyProperty.Register(
                nameof(CornerRadius),
                typeof(CornerRadius),
                typeof(SelectorButtons),
                new FrameworkPropertyMetadata(
                    new CornerRadius(),
                    FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender
                )
            );


        static SelectorButtons()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(SelectorButtons),
                new FrameworkPropertyMetadata(typeof(SelectorButtons))
            );
        }

        public SelectorButtons()
        {
            DataContextChanged += _onDataContextChanged;
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        protected Grid? ButtonsGrid { get; set; }

        private void _fillContent()
        {
            if (ButtonsGrid == null)
            {
                return;
            }

            if (ButtonsGrid.Children.Count > 0)
            {
                return;
            }

            if (DataContext is not Enum)
            {
                return;
            }


            var enumType = DataContext.GetType();
            var converter = new EnumDescriptionTypeConverter(enumType);
            var values = Enum.GetValues(enumType);

            for (var i = 0; i < values.Length; i++)
            {
                var value = values.GetValue(i);

                ButtonsGrid.ColumnDefinitions.Add(
                    new ColumnDefinition
                    {
                        Width = GridLength.Auto,
                        SharedSizeGroup = "SelectorColumn"
                    }
                );

                var button = new SelectorButton
                {
                    Content = converter.ConvertTo(value, typeof(string)),
                    IsChecked = value?.Equals(DataContext),
                    DataContext = value
                };

                if (i == 0)
                {
                    button.CornerRadius = new CornerRadius(
                        CornerRadius.TopLeft,
                        0,
                        0,
                        CornerRadius.BottomLeft
                    );
                }
                else if (i == values.Length - 1)
                {
                    button.CornerRadius = new CornerRadius(
                        0,
                        CornerRadius.TopRight,
                        CornerRadius.BottomRight,
                        0
                    );
                }

                button.SetValue(Grid.ColumnProperty, i);
                button.Checked += _onChecked;

                ButtonsGrid.Children.Add(button);
            }
        }

        private void _onChecked(object sender, RoutedEventArgs e)
        {
            if (sender is SelectorButton button)
            {
                DataContext = button.DataContext;
            }
        }

        private void _onDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is SelectorButtons selectorButtons)
            {
                selectorButtons._fillContent();
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            ButtonsGrid = GetTemplateChild(nameof(ButtonsGrid)) as Grid
                          ?? throw new TemplateChildNotExistsException(nameof(ButtonsGrid));

            _fillContent();
        }
    }
}