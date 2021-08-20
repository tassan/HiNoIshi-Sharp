using Microsoft.AspNetCore.Mvc;

namespace HiNoIshi.Application.Controllers
{
    [Route("characters")]
    [ApiController]
    public class CharactersController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}