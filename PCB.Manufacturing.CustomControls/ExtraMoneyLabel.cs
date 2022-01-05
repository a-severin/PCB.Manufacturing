using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.CustomControls
{
    public class ExtraMoneyLabel : TextBlock
    {
        static ExtraMoneyLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(ExtraMoneyLabel),
                new FrameworkPropertyMetadata(typeof(ExtraMoneyLabel))
            );
        }
    }
}