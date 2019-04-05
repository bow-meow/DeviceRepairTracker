using LaptopRepairTracker.ViewModels;
using LaptopRepairTracker.Views;
using System.Windows;
using Unity;

namespace LaptopRepairTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var container = CompositionFactory.GetContainer();

            CompositionFactory.Compose(container);

            var mainWindow = new MainWindow();
            mainWindow.DataContext = container.Resolve<IMainWindowViewModel>();

            mainWindow.Show();
        }
    }
}
