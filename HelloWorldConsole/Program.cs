using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace HelloWorldConsole
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            // setting up the service dependencies for this application
            var serviceColletion = new ServiceCollection();
            ConfigureServices(serviceColletion);
            var services = serviceColletion.BuildServiceProvider();

            // retrieve greeting from a Web aPI
            string greeting = await RetrieveGreeting();

            // retrieve the service registered to write the message received by the web api
            IWriter writer = services.GetRequiredService<IWriter>();
            
            // write message
            writer.Write(greeting);
        }

        static private void ConfigureServices(IServiceCollection serviceCollection)
        {
            // register service in charge of writing message. The specific component to be used is listed in the application settings.
            IConfigurationRoot jsonSettings = Settings.JsonSettings(new System.IO.FileInfo("appsettings.json"));
            serviceCollection.AddSingleton<IWriter>(WriterFactory.CreateWriter(jsonSettings["WriterType"]));
        }

        static async Task<string> RetrieveGreeting()
        {
            var greeting = string.Empty;

            IConfigurationRoot jsonSettings = Settings.JsonSettings(new System.IO.FileInfo("appsettings.json"));
            using (HttpClient client = new HttpClient())
            {
                // Call asynchronous network methods in a try/catch block to handle exceptions
                try
                {
                    greeting = await client.GetStringAsync(jsonSettings["GreetingUri"]);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }

            return greeting;
        }
    }
}
