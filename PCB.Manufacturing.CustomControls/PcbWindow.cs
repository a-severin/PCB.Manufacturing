using System.Windows;

namespace PCB.Manufacturing.CustomControls
{
    public class PcbWindow : Window
    {
        static PcbWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(PcbWindow),
                new FrameworkPropertyMetadata(typeof(PcbWindow))
            );
        }
    }
}