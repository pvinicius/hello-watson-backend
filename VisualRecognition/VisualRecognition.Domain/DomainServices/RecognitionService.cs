using IBM.WatsonDeveloperCloud.Util;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;
using VisualRecognition.Domain.Interfaces.DomainServices;
using System.IO;

namespace VisualRecognition.Domain.DomainServices
{
    public class RecognitionService : IRecognitionService
    {
        public ClassifiedImages Get()
        {
            try
            {
                const string VersionDate = "2018-03-19";
                TokenOptions tokenOptions = new TokenOptions()
                {
                    IamApiKey = "Mb2XLMvQdUWiVhOopDZ9I9-5VCjdvpJ07Mn4bplsChaO",
                    ServiceUrl = "https://gateway.watsonplatform.net/visual-recognition/api",
                };

                var service = new VisualRecognitionService(tokenOptions, VersionDate);

                ClassifiedImages classifiedImages;

                var imagePath = @"C:\Users\pedro.araujo.correia\Desktop\giraffe-classify.jpg";

                using (FileStream fs = File.OpenRead(imagePath))
                {
                    classifiedImages = service.Classify
                    (
                        imagesFile: fs,
                        imagesFileContentType: "image/jpeg",
                        threshold: 0.5f,
                        acceptLanguage: "pt-BR"
                    );
                }

                return classifiedImages;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
