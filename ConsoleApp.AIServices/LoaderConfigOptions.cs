namespace ConsoleApp.AIServices
{
    public class LoaderConfigOptions
    {
        public ComputerVisionConfig ComputerVisionConfig { get; set; }
        public static LoaderConfigOptions Configs;
        public LoaderConfigOptions(LoaderConfigOptions loaderConfigOptions) 
        {
            Configs = loaderConfigOptions;
        }
        public LoaderConfigOptions()
        {
            
        }
    }

    public class ComputerVisionConfig
    {
        public string Endpoint { get; set; }
        public string Key { get; set; }
    }
}
