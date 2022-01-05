using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.CustomControls
{
    public class ExtraTimeLabel : TextBlock
    {
        static ExtraTimeLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ExtraTimeLabel),
                new FrameworkPropertyMetadata(typeof(ExtraTimeLabel))
            );
        }
    }
}