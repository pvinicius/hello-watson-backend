using Microsoft.AspNetCore.Mvc;

namespace VisualRecognition.API
{
    [Route("api/[controller]")]
    public class RecognitionController : ControllerBase
    {
        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]string value)
        {
            return Ok(value);
        }
    }
}
