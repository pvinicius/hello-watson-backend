using Microsoft.AspNetCore.Mvc;
using VisualRecognition.Domain.Entities;
using VisualRecognition.Domain.Interfaces.DomainServices;

namespace VisualRecognition.API.Controllers
{
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        #region Attributes
        private readonly IImageService _imageService;
        #endregion

        #region Constructors
        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }
        #endregion

        #region Methods
        [HttpGet]
        public IActionResult GetAll()
        {
            var entities = _imageService.GetAll();
            return Ok(entities);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Image entity)
        {
            entity = _imageService.Post(entity);
            return Ok(entity);
        }
        #endregion
    }
}