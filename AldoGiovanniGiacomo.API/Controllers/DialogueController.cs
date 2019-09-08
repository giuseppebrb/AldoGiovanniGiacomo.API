using AldoGiovanniGiacomo.API.Contexts;
using AldoGiovanniGiacomo.API.DTOs;
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
        private static readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
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
        [ProducesResponseType(typeof(DialogueDTO), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDialogues()
        {
            _logger.LogInformation("Getting collection of every dialogue @ {DATE}", DateTime.UtcNow);
            ICollection<DialogueDTO> dialoguesDTO = new List<DialogueDTO>();

            foreach (var dialogue in await _context.Dialogues.ToListAsync())
            {
                dialoguesDTO.Add(new DialogueDTO
                {
                    Id = dialogue.Id,
                    Content = dialogue.Content.Replace("\r\n    ", "\n"),
                    Movie = dialogue.Movie.Title,
                    Year = dialogue.Movie.Year
                });
            }
            return Ok(dialoguesDTO);
        }

        /// <summary>
        /// Gets a specific dialogue
        /// </summary>
        /// <param name="id">Dialogue identifier</param>
        /// <returns>The selected dialogue</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(DialogueDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetDialogue(int id)
        {
            _logger.LogInformation("Getting dialogue with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var dialogue = await _context.Dialogues.FindAsync(id);

            if (dialogue == null)
            {
                _logger.LogWarning("Not found dialogue with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var dialogueDTO = new DialogueDTO
            {
                Id = dialogue.Id,
                Content = dialogue.Content.Replace("\r\n    ", "\n"),
                Movie = dialogue.Movie.Title,
                Year = dialogue.Movie.Year
            };

            return Ok(dialogueDTO);
        }

        /// <summary>
        /// Gets a random dialogue from a random movie
        /// </summary>
        /// <returns>A random dialogue</returns>
        [HttpGet("random")]
        [ProducesResponseType(typeof(DialogueDTO), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetRandomDialogue()
        {
            _logger.LogInformation("Getting a random dialogue @ {DATE}", DateTime.UtcNow);

            int randomIndex = _random.Next(1, _context.Dialogues.Count());
            var randomDialogue = await _context.Dialogues.FindAsync(randomIndex);

            var randomDialogueDTO = new DialogueDTO
            {
                Id = randomDialogue.Id,
                Content = randomDialogue.Content.Replace("\r\n    ", "\n"),
                Movie = randomDialogue.Movie.Title,
                Year = randomDialogue.Movie.Year
            };

            return Ok(randomDialogueDTO);
        }
    }
}
