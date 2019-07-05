using System.Collections.Generic;
using VisualRecognition.Domain.DTO;
using VisualRecognition.Domain.Entities;
using VisualRecognition.Domain.Interfaces.DomainServices;
using VisualRecognition.Domain.Interfaces.Repositories;

namespace VisualRecognition.Domain.DomainServices
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;
        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        public IEnumerable<Image> GetAll()
        {
            return _imageRepository.GetAll();
        }
        public Image Post(string file)
        {
            var entity = new Image(file);
            entity = _imageRepository.Add(entity);

            return entity;
        }
    }
}
