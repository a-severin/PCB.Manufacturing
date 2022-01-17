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

namespace PCB.Manufacturing.UI.Shell
{
    /// <summary>
    /// Interaction logic for MainContent.xaml
    /// </summary>
    public partial class MainContent : UserControl
    {
        public MainContent()
        {
            InitializeComponent();
        }

        private void Expander_OnExpanded(object sender, RoutedEventArgs e)
        {
            var element = (UIElement)sender;
            var index = Grid.Children.IndexOf(element);
            Grid.RowDefinitions[index]
                .Height = new GridLength(1, GridUnitType.Star);
        }

        private void Expander_OnCollapsed(object sender, RoutedEventArgs e)
        {
            var element = (UIElement)sender;
            var index = Grid.Children.IndexOf(element);
            Grid.RowDefinitions[index].Height = GridLength.Auto;
        }
    }
}
