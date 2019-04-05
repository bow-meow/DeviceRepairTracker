using LaptopRepairTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Unity;

namespace LaptopRepairTracker.Factory
{
    public class UiFactory : IUiFactory
    {
        private IUnityContainer _container;

        public UiFactory(IUnityContainer container)
        {
            _container = container;
        }

        public SettingsView GetSettingsView()
        {
            var settingsView = _container.Resolve<SettingsView>();

            settingsView.Owner = Application.Current.MainWindow;

            return settingsView;
        }
    }
}
