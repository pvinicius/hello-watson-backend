using IBM.WatsonDeveloperCloud.Util;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;
using VisualRecognition.Domain.Interfaces.DomainServices;
using System.IO;
using System.Collections.Generic;

namespace VisualRecognition.Domain.DomainServices
{
    public class RecognitionService : IRecognitionService
    {
        public ClassifiedImages Classify()
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

                var imagePath = @"C:\Users\pedro.araujo.correia\Pictures\arroz.jpg";
                using (FileStream fs = File.OpenRead(imagePath))
                {
                    classifiedImages = service.Classify
                    (
                        classifierIds: new List<string>() { "food" },
                        imagesFile: fs,
                        imagesFileContentType: "image/jpeg",
                        threshold: 0.5f,
                        acceptLanguage: "en-US"
                    );
                }

                return classifiedImages;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public DetectedFaces DetectedFaces()
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

                DetectedFaces detectedFaces;

                var imagePath = @"C:\Users\pedro.araujo.correia\Pictures\face-2.jpg";
                using (FileStream fs = File.OpenRead(imagePath))
                {
                    detectedFaces = service.DetectFaces
                    (
                        imagesFile: fs,
                        imagesFileContentType: "image/jpeg",
                        acceptLanguage: "en-US"
                    );
                }
                return detectedFaces;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
