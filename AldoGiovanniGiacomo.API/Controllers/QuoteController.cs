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
    [Route("api/quotes")]
    [Produces("application/json")]
    [ApiController]
    public class QuoteController : Controller
    {
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger _logger;

        public QuoteController(AldoGiovanniGiacomoAPIContext context, ILogger<QuoteController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Gets every quote, from every movie, said by Aldo, Giovanni e Giacomo
        /// </summary>
        /// <returns>A list of quotes</returns>
        [HttpGet]
        [ProducesResponseType(typeof(Quote), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetQuotes()
        {
            _logger.LogInformation("Getting collection of every quote @ {DATE}", DateTime.UtcNow);
            List<Quote> quotes = new List<Quote>();
            foreach (var quoteDTO in await _context.Quotes.ToListAsync())
            {
                quotes.Add(new Quote
                {
                    Actor = quoteDTO.Actor.Name + ' ' + quoteDTO.Actor.Surname,
                    Content = quoteDTO.Content,
                    Movie = quoteDTO.Movie.Title,
                    Year = quoteDTO.Movie.Year
                });
            }

            return Ok(quotes);
        }

        /// <summary>
        /// Gets a specific quote
        /// </summary>
        /// <param name="id">Quote identifier</param>
        /// <returns>The selected quote</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Quote), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetQuote(int id)
        {
            _logger.LogInformation("Getting quote with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var quoteDTO = await _context.Quotes.FindAsync(id);

            if (quoteDTO == null)
            {
                _logger.LogWarning("Not found quote with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var quoteVO = new Quote
            {
                Actor = quoteDTO.Actor.Name + ' ' + quoteDTO.Actor.Surname,
                Content = quoteDTO.Content,
                Movie = quoteDTO.Movie.Title,
                Year = quoteDTO.Movie.Year
            };

            return Ok(quoteVO);
        }

        /// <summary>
        /// Gets a random quote from a random movie
        /// </summary>
        /// <returns>A random quote</returns>
        [HttpGet("random")]
        [ProducesResponseType(typeof(Quote), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetRandomQuote()
        {
            _logger.LogInformation("Getting a random quote @ {DATE}", DateTime.UtcNow);
            var _random = new Random(Guid.NewGuid().GetHashCode());
            int randomIndex = _random.Next(1, _context.Quotes.Count());
            var randomQuoteDTO = await _context.Quotes.FindAsync(randomIndex);

            var randomQuoteVO = new Quote
            {
                Actor = randomQuoteDTO.Actor.Name + ' ' + randomQuoteDTO.Actor.Surname,
                Content = randomQuoteDTO.Content,
                Movie = randomQuoteDTO.Movie.Title,
                Year = randomQuoteDTO.Movie.Year
            };

            return Ok(randomQuoteVO);
        }
    }
}
