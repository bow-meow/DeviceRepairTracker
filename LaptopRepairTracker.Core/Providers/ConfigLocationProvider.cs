using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopRepairTracker.Core.Providers
{
    public class ConfigLocationProvider : IConfigLocationProvider
    {
        private const string _localConfigPath = @".NhsConfigs\LaptopRepairTracker";

        public string GetLocalUserConfigPath()
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(appData, _localConfigPath);

            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        public string GetLocalMachineConfigPath()
        {
            var cmnAppData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var path = Path.Combine(cmnAppData, _localConfigPath);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            return path;
        }
    }
}
