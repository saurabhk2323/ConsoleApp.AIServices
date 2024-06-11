using ConsoleApp.AIServices;
using ConsoleApp.AIServices.ComputerVision;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using static System.Console;
public class Program
{
    public static void Main(string[] args)
    {
        WriteLine("This is demo lab of all Azure Services");

        // build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false)
            .AddEnvironmentVariables()
            .Build();

        new LoaderConfigOptions(configuration.Get<LoaderConfigOptions>());

        AnalyzeImage analyzeImage = new AnalyzeImage();
        analyzeImage.AnalyzeImg().GetAwaiter().GetResult();

        WriteLine(LoaderConfigOptions.Configs);
    }
}