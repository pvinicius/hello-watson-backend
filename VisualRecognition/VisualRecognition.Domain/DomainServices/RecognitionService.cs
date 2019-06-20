using IBM.WatsonDeveloperCloud.Util;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3;
using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;
using VisualRecognition.Domain.Interfaces.DomainServices;
using System.IO;
using System.Collections.Generic;
using VisualRecognition.Domain.Entities;
using Microsoft.Extensions.Options;

namespace VisualRecognition.Domain.DomainServices
{
    public class RecognitionService : IRecognitionService
    {
        private readonly IOptions<Token> _token;
        public RecognitionService(IOptions<Token> token)
        {
            _token = token;
        }
        public ClassifiedImages Classify()
        {
            VisualRecognitionService service = StartService();
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
        public DetectedFaces DetectedFaces()
        {
            VisualRecognitionService service = StartService();
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

        private VisualRecognitionService StartService()
        {
            TokenOptions tokenOptions = new TokenOptions()
            {
                IamApiKey = _token.Value.IamApiKey,
                ServiceUrl = _token.Value.ServiceUrl,
            };

            var service = new VisualRecognitionService(tokenOptions, _token.Value.VersionDate);

            return service;
        }
    }
}
