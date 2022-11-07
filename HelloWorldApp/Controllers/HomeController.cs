using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: HomeController
        [HttpGet("/")]
        public ActionResult Index()
        {
            return Ok("Hello world!");
        }
    }
}
