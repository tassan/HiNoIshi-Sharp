using HiNoIshi.Domain.Core.CharacterData;
using HiNoIshi.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HiNoIshi.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CharacterModel character)
        {
            return Ok(character);
        }
    }
}