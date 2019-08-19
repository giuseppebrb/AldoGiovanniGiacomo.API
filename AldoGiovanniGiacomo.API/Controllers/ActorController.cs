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

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int randomIndex = rnd.Next(actor.Quotes.Count());
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
    }
}
