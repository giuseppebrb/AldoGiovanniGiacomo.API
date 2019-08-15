using AldoGiovanniGiacomo.API.Contexts;
using AldoGiovanniGiacomo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AldoGiovanniGiacomo.API.Controllers
{
    [Route("api/dialogues")]
    [Produces("application/json")]
    [ApiController]
    public class DialogueController : Controller
    {
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger _logger;

        public DialogueController(AldoGiovanniGiacomoAPIContext context, ILogger<DialogueController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Gets every dialogue, from every movie, said by Aldo, Giovanni e Giacomo
        /// </summary>
        /// <returns>A list of dialogues</returns>
        [HttpGet]
        [ProducesResponseType(typeof(Dialogue), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDialogues()
        {
            _logger.LogInformation("Getting collection of every dialogue @ {DATE}", DateTime.UtcNow);
            ICollection<Dialogue> dialogues = new List<Dialogue>();

            foreach (var dialogueDTO in await _context.Dialogues.ToListAsync())
            {
                dialogues.Add(new Dialogue
                {
                    Content = dialogueDTO.Content,
                    Movie = dialogueDTO.Movie.Title,
                    Year = dialogueDTO.Movie.Year
                });
            }
            return Ok(dialogues);
        }

        /// <summary>
        /// Gets a specific dialogue
        /// </summary>
        /// <param name="id">Dialogue identifier</param>
        /// <returns>The selected dialogue</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Dialogue), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDialogue(int id)
        {
            _logger.LogInformation("Getting dialogue with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var dialogueDTO = await _context.Dialogues.FindAsync(id);

            if (dialogueDTO == null)
            {
                _logger.LogWarning("Not found dialogue with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var dialogueVO = new Dialogue
            {
                Content = dialogueDTO.Content,
                Movie = dialogueDTO.Movie.Title,
                Year = dialogueDTO.Movie.Year
            };

            return Ok(dialogueVO);
        }

        /// <summary>
        /// Gets a random dialogue from a random movie
        /// </summary>
        /// <returns>A random dialogue</returns>
        [HttpGet("random")]
        [ProducesResponseType(typeof(Dialogue), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetRandomDialogue()
        {
            _logger.LogInformation("Getting a random dialogue @ {DATE}", DateTime.UtcNow);
            var _random = new Random(Guid.NewGuid().GetHashCode());
            int randomIndex = _random.Next(1, _context.Dialogues.Count());
            var randomDialogueDTO = await _context.Dialogues.FindAsync(randomIndex);

            var randomDialogueVO = new Dialogue
            {
                Content = randomDialogueDTO.Content,
                Movie = randomDialogueDTO.Movie.Title,
                Year = randomDialogueDTO.Movie.Year
            };

            return Ok(randomDialogueVO);
        }
    }
}
