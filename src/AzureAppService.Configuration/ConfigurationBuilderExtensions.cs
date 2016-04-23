using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace AzureAppService.Configuration
{
    public static class ConfigurationBuilderExtensions
    {
        public static IConfigurationBuilder AddAzureAppServiceSettings(this IConfigurationBuilder builder)
        {
            builder.Add(new AzureAppServiceConfigurationProvider());
            return builder;
        }
    }
}
