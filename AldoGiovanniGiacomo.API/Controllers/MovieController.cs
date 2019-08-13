using AldoGiovanniGiacomo.API.Contexts;
using AldoGiovanniGiacomo.API.DTOs;
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
    [Route("api/movies")]
    [Produces("application/json")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger _logger;

        public MovieController(AldoGiovanniGiacomoAPIContext context, ILogger<MovieController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Gets the movie list of Aldo, Giovanni e Giacomo with details
        /// </summary>
        /// <returns>A list containg details about every movie</returns>
        [HttpGet]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovies()
        {
            _logger.LogInformation("Getting collection of every movie @ {DATE}", DateTime.UtcNow);
            List<Movie> movies = new List<Movie>();

            foreach (var movieDTO in await _context.Movies.ToListAsync())
            {
                ICollection<Quote> movieQuotes = MapMovieQuotes(movieDTO);
                ICollection<Dialogue> movieDialogues = MapMovieDialogues(movieDTO);

                movies.Add(new Movie
                {
                    Year = movieDTO.Year,
                    Title = movieDTO.Title,
                    Quotes = movieQuotes,
                    Dialogues = movieDialogues,
                    Director = movieDTO.Director
                });
            }

            return Ok(movies);
        }

        /// <summary>
        /// Gets details of the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>Details of the movie</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Movie), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovie(int id)
        {
            _logger.LogInformation("Getting movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var movieDTO = await _context.Movies.FindAsync(id);

            if (movieDTO == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            ICollection<Quote> movieQuotes = MapMovieQuotes(movieDTO);
            var movieVO = new Movie
            {
                Year = movieDTO.Year,
                Title = movieDTO.Title,
                Quotes = movieQuotes,
                Director = movieDTO.Director
            };

            return Ok(movieVO);
        }

        /// <summary>
        /// Gets a list of quotes taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A list of quotes from the movie</returns>
        [HttpGet("{id}/quotes")]
        [ProducesResponseType(typeof(Quote), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieQuotes(int id)
        {
            _logger.LogInformation("Getting quotes from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var movieDTO = await _context.Movies.FindAsync(id);

            if (movieDTO == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            ICollection<Quote> movieQuotes = MapMovieQuotes(movieDTO);
            return Ok(movieQuotes);
        }

        /// <summary>
        /// Get a random quote taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A random quote from the movie</returns>
        [HttpGet("{id}/quotes/random")]
        [ProducesResponseType(typeof(Quote), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieRandomQuote(int id)
        {
            _logger.LogInformation("Getting random quote from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var movieDTO = await _context.Movies.FindAsync(id);
            if (movieDTO == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var random = new Random(Guid.NewGuid().GetHashCode());
            var randomIndex = random.Next(1, movieDTO.Quotes.Count);
            QuoteDTO randomQuoteDTO = movieDTO.Quotes.ElementAt(randomIndex);

            var randomQuote = new Quote
            {
                Actor = randomQuoteDTO.Actor.Name + ' ' + randomQuoteDTO.Actor.Surname,
                Content = randomQuoteDTO.Content,
                Year = movieDTO.Year
            };
            return Ok(randomQuote);
        }

        /// <summary>
        /// Gets a list of dialogues taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A list of dialogues from the movie</returns>
        [HttpGet("{id}/dialogues")]
        [ProducesResponseType(typeof(Dialogue), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieDialogues(int id)
        {
            _logger.LogInformation("Getting dialogues from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var movieDTO = await _context.Movies.FindAsync(id);

            if (movieDTO == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            ICollection<Dialogue> movieDialogues = MapMovieDialogues(movieDTO);
            return Ok(movieDialogues);
        }

        /// <summary>
        /// Get a random dialogue taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A random dialogue from the movie</returns>
        [HttpGet("{id}/dialogues/random")]
        [ProducesResponseType(typeof(Dialogue), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieRandomDialogue(int id)
        {
            _logger.LogInformation("Getting random dialogue from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var movieDTO = await _context.Movies.FindAsync(id);
            if (movieDTO == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var random = new Random(Guid.NewGuid().GetHashCode());
            var randomIndex = random.Next(1, movieDTO.Dialogues.Count);
            DialogueDTO randomQuoteDTO = movieDTO.Dialogues.ElementAt(randomIndex);

            var randomQuote = new Quote
            {
                Content = randomQuoteDTO.Content,
                Year = movieDTO.Year
            };
            return Ok(randomQuote);
        }

        private ICollection<Quote> MapMovieQuotes(MovieDTO movieDTO)
        {
            List<Quote> movieQuotes = new List<Quote>();
            foreach (var quoteDTO in movieDTO.Quotes)
            {
                movieQuotes.Add(new Quote
                {
                    Actor = quoteDTO.Actor.Name + ' ' + quoteDTO.Actor.Surname,
                    Content = quoteDTO.Content,
                    Year = movieDTO.Year
                });
            }
            return movieQuotes;
        }

        private ICollection<Dialogue> MapMovieDialogues(MovieDTO movieDTO)
        {
            List<Dialogue> movieDialogues = new List<Dialogue>();
            foreach (var dialogueDTO in movieDTO.Dialogues)
            {
                movieDialogues.Add(new Dialogue
                {
                    Content = dialogueDTO.Content,
                    Year = movieDTO.Year
                });
            }
            return movieDialogues;
        }
    }
}
