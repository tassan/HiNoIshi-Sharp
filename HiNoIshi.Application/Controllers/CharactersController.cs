using HiNoIshi.Domain.Core.CharacterData;
using HiNoIshi.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HiNoIshi.Application.Controllers.Api
{
    [Route("characters")]
    [ApiController]
    public class CharactersController : Controller
    {
        private readonly ICharacterRepository _characterRepository;

        public CharactersController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCharacter([FromBody] Character character)
        {
            _characterRepository.Add(character);

            return Ok();
        }
    }
}