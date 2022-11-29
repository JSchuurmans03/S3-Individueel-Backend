using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testDataAccess.Data;
using testDataAccess.Models;

namespace testDataAccess.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CharacterTestController : Controller
    {
        private readonly CharacterTestService _context;

        public CharacterTestController(CharacterTestService context)
        {
            _context = context;
        }

        // GET: api/Characters
        [HttpGet]
        public JsonResult Characters()
        {
            List<CharacterTest> characterTests = ReturnCharacters();
            return Json(characterTests);
        }

        private List<CharacterTest> ReturnCharacters()
        {
            List<CharacterTest> characterTests = new();
            foreach (var characterTest in _context.CharacterTests())
            {
                characterTests.Add(characterTest);
            }

            return characterTests;
        }


    }
}
