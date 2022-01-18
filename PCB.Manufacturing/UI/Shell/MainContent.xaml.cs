using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.UI.Shell
{
    /// <summary>
    ///     Interaction logic for MainContent.xaml
    /// </summary>
    public partial class MainContent : UserControl
    {
        public MainContent()
        {
            InitializeComponent();
        }

        private void Expander_OnCollapsed(object sender, RoutedEventArgs e)
        {
            var element = (UIElement)sender;
            var index = Grid.Children.IndexOf(element);
            Grid.RowDefinitions[index]
                .Height = GridLength.Auto;
        }

        private void Expander_OnExpanded(object sender, RoutedEventArgs e)
        {
            var element = (UIElement)sender;
            var index = Grid.Children.IndexOf(element);
            Grid.RowDefinitions[index]
                .Height = new GridLength(1, GridUnitType.Star);
        }
    }
}