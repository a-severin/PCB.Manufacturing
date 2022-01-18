using System.Windows;
using System.Windows.Controls;

namespace PCB.Manufacturing.UI.Shell
{
    /// <summary>
    ///     Interaction logic for MainFooter.xaml
    /// </summary>
    public partial class MainFooter : UserControl
    {
        public MainFooter()
        {
            InitializeComponent();
        }

        private void CloseButton_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}