using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtemisApi.Data;
using ArtemisApi.Data.Entities;
using ArtemisApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtemisApi.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class WordSetsController : ControllerBase {
        private readonly ArtemisContext _context;

        public WordSetsController (ArtemisContext context) {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<WordSetDto>> Get () =>
            Ok (_context.WordSets.AsEnumerable ().Select (wordSet => new WordSetDto (wordSet.Id, wordSet.Title)));

        [HttpGet ("{id}")]
        public ActionResult<WordSetDto> Get (int id) {
            var wordSet = _context.WordSets.Include (ws => ws.Words)
                .SingleOrDefault (ws => ws.Id == id);
            return Ok (new WordSetDto (wordSet.Id, wordSet.Title, wordSet.Words.Select (word => new WordDto (word.Id, word.Primary, word.Secondary, null))));
        }

    }
}