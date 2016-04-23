# Azure App Service Configuration
ASP.Net 5 Configuration helper for getting settings from an Azure App Service into the `ConfigurationBuilder`

[Download](https://www.nuget.org/packages/AzureAppService.Configuration) on Nuget.org

## Usage
In your Startup.cs, simply call `AddAzureAppServiceSettings()`. Generally you will want the Azure App Service settings to override the settings packaged with your application because they contain secrets or other environment-specific configuration, so you will have it be later than the `appsettings.json` file config.

```cs
public Startup(IHostingEnvironment env)
{
    // Set up configuration sources.
    var builder = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .AddAzureAppServiceSettings();
    this.Configuration = builder.Build();
}
```

This will add all application settings and connection strings to the `ConfigurationBuilder`.

## License
[MIT](LICENSE)