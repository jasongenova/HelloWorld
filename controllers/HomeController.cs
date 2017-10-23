using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("~/", Name = "default")]
        public IActionResult Index()
        {
            return Ok("Hello from ASP.NET CORE");
        }

        [Route("{*url}", Order = 9999)]
        public IActionResult CatchAll()
        {
            return NotFound("Route Not Found.");
        }
    }
}