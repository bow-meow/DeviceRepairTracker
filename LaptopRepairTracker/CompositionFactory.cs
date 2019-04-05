using LaptopRepairTracker.Factory;
using LaptopRepairTracker.ViewModels;
using LaptopRepairTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace LaptopRepairTracker
{
    public static class CompositionFactory
    {
        private static IUnityContainer _container = new UnityContainer();

        public static void Compose(IUnityContainer container)
        {
            //viewmodels
            container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();
            container.RegisterType<ISettingsViewModel, SettingsViewModel>();

            //views
            container.RegisterType<SettingsView>();

            //factory
            container.RegisterType<IUiFactory, UiFactory>();
        }

        public static IUnityContainer GetContainer()
        {
            return _container;
        }
    }
}
