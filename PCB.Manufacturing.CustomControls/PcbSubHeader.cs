using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.CustomControls
{
    public class PcbSubHeader : TextBlock
    {
        static PcbSubHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(PcbSubHeader),
                new FrameworkPropertyMetadata(typeof(PcbSubHeader))
            );
        }
    }
}