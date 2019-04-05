using LaptopRepairTracker.Core.Base;
using LaptopRepairTracker.Core.Command;
using LaptopRepairTracker.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LaptopRepairTracker.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
    {
        private readonly IUiFactory _uiFactory;

        public MainWindowViewModel(IUiFactory uiFactory)
        {
            _uiFactory = uiFactory;

            InitCommands();
        }

        public ICommand LaunchSettingsCommand { get; set; }

        private void InitCommands()
        {
            LaunchSettingsCommand = new RelayCommand(ExecuteLaunchSettingsCommand, CanExecuteLaunchSettingsCommand);
        }

        private bool CanExecuteLaunchSettingsCommand(object obj)
        {
            return true;
        }

        private void ExecuteLaunchSettingsCommand(object obj)
        {
            _uiFactory.GetSettingsView().Show();
        }
    }
}
