using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleAPIApp.Model
{
    /// <summary>
    /// Settings model
    /// </summary>
    public class SettingsModel
    {
        public string url { get; set; }

        public string appId { get; set; }

        public string developerKey { get; set; }

        public SettingsModel()
        {
            this.url = ConfigurationManager.AppSettings["url"];
            this.appId = ConfigurationManager.AppSettings["appId"];
            this.developerKey = ConfigurationManager.AppSettings["developerKey"];
        }
    }
}
