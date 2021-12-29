using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.CustomControls
{
    public class PcbGroupBox : GroupBox
    {
        static PcbGroupBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(PcbGroupBox),
                new FrameworkPropertyMetadata(typeof(PcbGroupBox))
            );
        }

        public static readonly DependencyProperty SubHeaderProperty = DependencyProperty.Register(
            nameof(SubHeader),
            typeof(object),
            typeof(PcbGroupBox),
            new FrameworkPropertyMetadata(null, _onSubHeaderChanged)
        );

        private static void _onSubHeaderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ctrl = (PcbGroupBox)d;
            ctrl.RemoveLogicalChild(e.OldValue);
            ctrl.AddLogicalChild(e.NewValue);
        }

        [Bindable(true), Category("Content")]
        [Localizability(LocalizationCategory.Label)]
        public object SubHeader
        {
            get => GetValue(SubHeaderProperty);
            set => SetValue(SubHeaderProperty, value);
        }
    }
}