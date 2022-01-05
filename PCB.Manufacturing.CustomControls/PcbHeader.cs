using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.CustomControls
{
    public class PcbHeader : TextBlock
    {
        static PcbHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(PcbHeader),
                new FrameworkPropertyMetadata(typeof(PcbHeader))
            );
        }
    }
}