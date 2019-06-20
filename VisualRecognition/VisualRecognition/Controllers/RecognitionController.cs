using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;
using Microsoft.AspNetCore.Mvc;
using VisualRecognition.Domain.Interfaces.DomainServices;

namespace VisualRecognition.API.Controllers
{
    [Route("api/[controller]")]
    public class RecognitionController : ControllerBase
    {
        #region Attributes
        private readonly IRecognitionService _recognitionService;
        #endregion

        #region constructors
        public RecognitionController(IRecognitionService recognitionService)
        {
            _recognitionService = recognitionService;
        }
        #endregion

        #region Methods
        [HttpGet]
        [Route("classify")]
        public ActionResult<ClassifiedImages> Classify()
        {
            var result = _recognitionService.Classify();
            return Ok(result);
        }
        [HttpGet]
        [Route("detected-faces")]
        public ActionResult<DetectedFaces> DetectedFaces()
        {
            var result = _recognitionService.DetectedFaces();
            return Ok(result);
        }
        #endregion
    }
}
