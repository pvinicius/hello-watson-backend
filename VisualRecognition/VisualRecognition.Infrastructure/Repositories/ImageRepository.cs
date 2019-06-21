using System.Collections.Generic;
using System.Linq;
using VisualRecognition.Domain.Entities;
using VisualRecognition.Domain.Interfaces.Repositories;
using VisualRecognition.Infrastructure.Contexts;

namespace VisualRecognition.Infrastructure.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ImageContext _imageContext;
        public ImageRepository(ImageContext imageContext)
        {
            _imageContext = imageContext;
        }
        public Image Get(int id)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<Image> GetAll()
        {
            try
            {
                return _imageContext.Image.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public Image Add(Image entity)
        {
            try
            {
                _imageContext.Image.Add(entity);
                _imageContext.SaveChanges();

                return entity;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public Image Update(Image entity)
        {
            throw new System.NotImplementedException();
        }
        public bool Delete(Image entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
