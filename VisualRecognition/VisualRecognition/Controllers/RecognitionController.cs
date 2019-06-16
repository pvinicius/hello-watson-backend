using IBM.WatsonDeveloperCloud.VisualRecognition.v3.Model;
using Microsoft.AspNetCore.Mvc;
using VisualRecognition.Domain.Interfaces.DomainServices;

namespace VisualRecognition.API.Controllers
{
    [Route("api/[controller]")]
    public class RecognitionController : Controller
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
        [Route("visual")]
        public ActionResult<ClassifiedImages> Get()
        {
            var result = _recognitionService.Get();
            return Ok(result);
        }
        #endregion
    }
}
