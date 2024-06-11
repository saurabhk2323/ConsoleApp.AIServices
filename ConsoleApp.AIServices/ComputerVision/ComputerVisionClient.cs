using Azure.AI.Vision.ImageAnalysis;

namespace ConsoleApp.AIServices.ComputerVision
{
    public class ComputerVisionClient
    {
        private readonly ImageAnalysisClient imageAnalysisClient;
        private LoaderConfigOptions configs;
        public ComputerVisionClient()
        {
            configs = LoaderConfigOptions.Configs;

            imageAnalysisClient = new ImageAnalysisClient(
                new Uri(configs.ComputerVisionConfig.Endpoint),
                new Azure.AzureKeyCredential(configs.ComputerVisionConfig.Key)
                );
        }

        public ImageAnalysisClient GetImageAnalysisClient() => imageAnalysisClient;
    }
}
