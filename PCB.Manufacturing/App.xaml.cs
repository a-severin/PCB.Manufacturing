using System.Windows;
using PCB.Manufacturing.UI.Shell;

namespace PCB.Manufacturing
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ShutdownMode = ShutdownMode.OnMainWindowClose;
            MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}