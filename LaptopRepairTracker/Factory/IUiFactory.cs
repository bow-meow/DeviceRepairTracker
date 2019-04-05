using LaptopRepairTracker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopRepairTracker.Factory
{
    public interface IUiFactory
    {
        SettingsView GetSettingsView();
    }
}
