using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.UrlShortener.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
