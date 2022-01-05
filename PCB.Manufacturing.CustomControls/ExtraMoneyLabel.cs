using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCB.Manufacturing.CustomControls
{
    public class ExtraMoneyLabel : TextBlock
    {
        static ExtraMoneyLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExtraMoneyLabel), new FrameworkPropertyMetadata(typeof(ExtraMoneyLabel)));
        }
    }
}
