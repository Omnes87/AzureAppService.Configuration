using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace AzureAppService.Configuration
{
    public class AzureAppServiceConfigurationProvider : ConfigurationProvider
    {
        public AzureAppServiceConfigurationProvider()
        {
        }

        public override void Load()
        {
            var data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var appSettings = ConfigurationManager.AppSettings;
            foreach (string appSetting in appSettings.Keys)
            {
                data[appSetting] = appSettings[appSetting];
            }

            var connectionStrings = ConfigurationManager.ConnectionStrings;
            foreach (ConnectionStringSettings connectionString in connectionStrings)
            {
                data[connectionString.Name] = connectionString.ConnectionString;
            }

            this.Data = data;
        }
    }
}
