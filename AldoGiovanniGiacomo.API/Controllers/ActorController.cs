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
    [Route("api/actors")]
    [Produces("application/json")]
    [ApiController]
    public class ActorController : Controller
    {
        private static readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger _logger;

        public ActorController(AldoGiovanniGiacomoAPIContext context, ILogger<ActorController> logger)
        {
            _context = context;
            _logger = logger;
        }
        /// <summary>
        /// Retrieve anagraphic infos about the actors Aldo, Giovanni e Giacomo
        /// </summary>
        /// <returns>An array with details of every actor</returns>
        [HttpGet]
        [ProducesResponseType(typeof(ActorDTO), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetActors()
        {
            _logger.LogInformation("Getting collection of every actor @ {DATE}", DateTime.UtcNow);
            List<ActorDTO> actorsDTO = new List<ActorDTO>();
            foreach (var actor in await _context.Actors.ToListAsync())
                actorsDTO.Add(new ActorDTO
                {
                    Id = actor.Id,
                    Name = actor.Name,
                    Nickname = actor.Nickname,
                    Surname = actor.Surname,
                    Birth = actor.Birth,
                    BirthPlace = actor.BirthPlace
                });
            return Ok(actorsDTO);
        }

        /// <summary>
        /// Retrieve anagraphic details about an actor
        /// </summary>
        /// <param name="id">Actor identifier</param>
        /// <returns>Anagraphic details about the specified actor</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ActorDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetActor(int id)
        {
            _logger.LogInformation("Getting actor with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var actor = await _context.Actors.FindAsync(id);

            if (actor == null)
            {
                _logger.LogWarning("Not found actor with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            ActorDTO actorDTO = new ActorDTO
            {
                Id = actor.Id,
                Name = actor.Name,
                Nickname = actor.Nickname,
                Surname = actor.Surname,
                BirthPlace = actor.BirthPlace,
                Birth = actor.Birth
            };

            return Ok(actorDTO);
        }

        /// <summary>
        /// Gets every quote, taken from every movie, said by the specified actor
        /// </summary>
        /// <param name="id">Actor identifier</param>
        /// <returns>A list of quotes associated to the specified actor</returns>
        [HttpGet("{id}/quotes")]
        [ProducesResponseType(typeof(QuoteDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetActorQuotes(int id)
        {
            _logger.LogInformation("Getting quotes of actor with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var actor = await _context.Actors.FindAsync(id);

            if (actor == null)
            {
                _logger.LogWarning("Not found actor with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var quotesDTO = new List<QuoteDTO>();
            foreach (var quote in actor.Quotes)
            {
                quotesDTO.Add(new QuoteDTO
                {
                    Id = quote.Id,
                    Content = quote.Content,
                    Movie = quote.Movie.Title,
                    Year = quote.Movie.Year
                });
            }

            return Ok(quotesDTO);
        }

        /// <summary>
        /// Get a random quote, from a random movie, said by the specified actor
        /// </summary>
        /// <param name="id">Actor identifier</param>
        /// <returns>A random quote</returns>
        [HttpGet("{id}/quotes/random")]
        [ProducesResponseType(typeof(QuoteDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetRandomQuote(int id)
        {
            _logger.LogInformation("Getting random quote of actor with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var actor = await _context.Actors.FindAsync(id);

            if (actor == null || actor.Quotes.Count() == 0)
            {
                _logger.LogWarning("Not found actor with Id: {ID} @ {DATE}", id, new DateTime());
                return NotFound();
            }

            int randomIndex = _random.Next(actor.Quotes.Count());
            var randomQuote = actor.Quotes.ToArray()[randomIndex];

            var randomQuoteDTO = new QuoteDTO
            {
                Id = randomQuote.Id,
                Content = randomQuote.Content,
                Movie = randomQuote.Movie.Title,
                Year = randomQuote.Movie.Year
            };

            return Ok(randomQuoteDTO);
        }

        /// <summary>
        /// Get a specific quote said by the specified actor
        /// </summary>
        /// <param name="actorId">Actor identifier</param>
        /// <param name="quoteId">Quote identifier</param>
        /// <returns>The quote of the actor with the specified id</returns>
        [HttpGet("{actorId}/quotes/{quoteId}")]
        [ProducesResponseType(typeof(QuoteDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetActorQuoteById(int actorId, int quoteId)
        {
            _logger.LogInformation("Getting quote with id {QuoteID} of actor with Id: {ID} @ {DATE}", quoteId, actorId, DateTime.UtcNow);
            var actor = await _context.Actors.FindAsync(actorId);

            if (actor == null)
            {
                _logger.LogWarning("Not found actor with Id: {ID} @ {DATE}", actorId, DateTime.UtcNow);
                return NotFound();
            }

            var quote = actor.Quotes.Where(q => q.Id == quoteId).SingleOrDefault();
            if (quote == null)
            {
                _logger.LogWarning("Not found quote with Id: {ID} @ {DATE}", quoteId, DateTime.UtcNow);
                return NotFound();
            }

            var quoteDTO = new QuoteDTO
            {
                Actor = actor.Name + ' ' + actor.Surname,
                Content = quote.Content,
                Id = quote.Id,
                Movie = quote.Movie.Title,
                Year = quote.Movie.Year
            };
            return Ok(quoteDTO);
        }

        /// <summary>
        /// Add a new actor inside the list of actors
        /// </summary>
        /// <param name="name">Name of the actor</param>
        /// <param name="surname">Surname</param>
        /// <param name="birth">Date of birth of the actor</param>
        /// <param name="birthPlace">Birthplace of the actor</param>
        /// <returns>The added actor</returns>
        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> PostActor(string name, string surname, DateTime birth, string birthPlace)
        {
            if (!IsValidStringInput(name) || !IsValidStringInput(surname)
                || !IsValidStringInput(birthPlace) || birth == null)
            {
                return BadRequest();
            }
            var actors = _context.Actors;
            actors.Add(new Models.Actor
            {
                Name = name,
                Surname = surname,
                Birth = birth,
                BirthPlace = birthPlace
            });
            await _context.SaveChangesAsync();

            var addedActor = _context.Actors.FirstOrDefaultAsync(a => a.Name == name && a.Surname == surname).Result;

            return CreatedAtAction(nameof(GetActor), new { id = addedActor.Id }, addedActor);
        }

        private bool IsValidStringInput(string input)
        {
            return !string.IsNullOrEmpty(input) && !string.IsNullOrWhiteSpace(input);
        }
    }
}
