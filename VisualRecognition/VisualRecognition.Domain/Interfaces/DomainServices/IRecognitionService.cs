using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;

namespace VisualRecognition.Domain.Interfaces.DomainServices
{
    public interface IRecognitionService
    {
        ClassifiedImages Classify(string imagePath);
        DetectedFaces DetectedFaces();
    }
}
