using Azure.AI.Vision.ImageAnalysis;

namespace ConsoleApp.AIServices.ComputerVision
{
    public class AnalyzeImage
    {
        private readonly ComputerVisionClient _computerVisionClient;
        private readonly ImageAnalysisClient _imageAnalysisClient;

        public AnalyzeImage()
        {
            _computerVisionClient = new ComputerVisionClient();
            _imageAnalysisClient = _computerVisionClient.GetImageAnalysisClient();
        }

        public async Task AnalyzeImg()
        {
            // get Image
            string imgFile = "C:\\Users\\saurabhkumar7\\source\\repos\\ConsoleApp.AIServices\\ConsoleApp.AIServices\\ComputerVision\\Images\\tajmahal.jpg";
            byte[] imageBytes = File.ReadAllBytes(imgFile);

            // get result with specified features to be retrieved
            ImageAnalysisResult result = await _imageAnalysisClient.AnalyzeAsync(
                new BinaryData(imageBytes),
                VisualFeatures.Caption |
                VisualFeatures.DenseCaptions |
                VisualFeatures.Objects |
                VisualFeatures.Tags |
                VisualFeatures.People
                );

            if (result != null)
            {
                foreach (var tag in result.Tags.Values)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}
