using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PCB.Manufacturing.CustomControls
{
    public class SelectorButton : RadioButton
    {
        public static readonly DependencyProperty CornerRadiusProperty
            = DependencyProperty.Register(
                nameof(CornerRadius),
                typeof(CornerRadius),
                typeof(SelectorButton),
                new FrameworkPropertyMetadata(
                    new CornerRadius(),
                    FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender
                )
            );

        public static readonly DependencyProperty CheckedBackgroundProperty
            = DependencyProperty.Register(
                nameof(CheckedBackground),
                typeof(Brush),
                typeof(SelectorButton),
                new FrameworkPropertyMetadata(
                    null,
                    FrameworkPropertyMetadataOptions.None
                )
            );

        static SelectorButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(SelectorButton),
                new FrameworkPropertyMetadata(typeof(SelectorButton))
            );
        }

        [Bindable(true), Category("Appearance")]
        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        [Bindable(true), Category("Appearance")]
        public Brush? CheckedBackground
        {
            get => (Brush)GetValue(CheckedBackgroundProperty);
            set => SetValue(CheckedBackgroundProperty, value);
        }
    }
}