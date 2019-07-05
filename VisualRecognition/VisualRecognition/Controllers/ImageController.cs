using Microsoft.AspNetCore.Mvc;
using VisualRecognition.Domain.DTO;
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
        [Route("upload")]
        public IActionResult Post([FromBody] string file)
        {
            var entity = _imageService.Post(file);
            return Ok(entity);
        }
        #endregion
    }
}