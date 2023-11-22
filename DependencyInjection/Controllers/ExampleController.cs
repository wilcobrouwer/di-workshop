using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        [Route("time")]
        public ActionResult GetTime()
        {
            var result = DateTime.Now;
            return Ok(result);
        }

		[HttpGet]
		[Route("numbers")]
		public ActionResult GetNumbers()
		{
			var result = new Random().Next();
			return Ok(result);
		}
	}
}
