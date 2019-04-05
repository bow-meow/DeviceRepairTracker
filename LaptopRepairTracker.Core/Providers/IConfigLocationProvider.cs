using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopRepairTracker.Core.Providers
{
    public interface IConfigLocationProvider
    {
        string GetLocalUserConfigPath();
        string GetLocalMachineConfigPath();
    }
}
