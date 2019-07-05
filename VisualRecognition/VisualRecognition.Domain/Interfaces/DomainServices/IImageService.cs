using System.Collections.Generic;
using VisualRecognition.Domain.DTO;
using VisualRecognition.Domain.Entities;

namespace VisualRecognition.Domain.Interfaces.DomainServices
{
    public interface IImageService
    {
        IEnumerable<Image> GetAll();
        Image Post(string file);
    }
}
