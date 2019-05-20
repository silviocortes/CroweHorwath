using Microsoft.Extensions.Configuration;
using System.IO;

namespace HelloWorldConsole
{
    static public class Settings
    {
        //retrieve JSON setting
        public static IConfigurationRoot JsonSettings(FileInfo settingsFile)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();

            configurationBuilder = configurationBuilder.AddJsonFile(settingsFile.FullName, false);

            return configurationBuilder.Build();
        }
    }
}
