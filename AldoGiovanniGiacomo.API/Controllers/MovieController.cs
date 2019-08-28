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
        private static readonly Random _random = new Random(Guid.NewGuid().GetHashCode());
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
        [ProducesResponseType(typeof(MovieDTO), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovies()
        {
            _logger.LogInformation("Getting collection of every movie @ {DATE}", DateTime.UtcNow);
            List<MovieDTO> moviesDTO = new List<MovieDTO>();

            foreach (var movie in await _context.Movies.ToListAsync())
            {
                ICollection<QuoteDTO> movieQuotes = MapMovieQuotes(movie);
                ICollection<DialogueDTO> movieDialogues = MapMovieDialogues(movie);

                moviesDTO.Add(new MovieDTO
                {
                    Id = movie.Id,
                    Year = movie.Year,
                    Title = movie.Title,
                    Quotes = movieQuotes,
                    Dialogues = movieDialogues,
                    Director = movie.Director
                });
            }

            return Ok(moviesDTO);
        }

        /// <summary>
        /// Gets details of the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>Details of the movie</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(MovieDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovie(int id)
        {
            _logger.LogInformation("Getting movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            ICollection<QuoteDTO> movieQuotes = MapMovieQuotes(movie);
            var movieDTO = new MovieDTO
            {
                Id = movie.Id,
                Year = movie.Year,
                Title = movie.Title,
                Quotes = movieQuotes,
                Director = movie.Director
            };

            return Ok(movieDTO);
        }

        /// <summary>
        /// Gets a list of quotes taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A list of quotes from the movie</returns>
        [HttpGet("{id}/quotes")]
        [ProducesResponseType(typeof(QuoteDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieQuotes(int id)
        {
            _logger.LogInformation("Getting quotes from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            ICollection<QuoteDTO> movieQuotesDTO = MapMovieQuotes(movie);
            return Ok(movieQuotesDTO);
        }

        /// <summary>
        /// Get a random quote taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A random quote from the movie</returns>
        [HttpGet("{id}/quotes/random")]
        [ProducesResponseType(typeof(QuoteDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieRandomQuote(int id)
        {
            _logger.LogInformation("Getting random quote from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var randomIndex = _random.Next(1, movie.Quotes.Count());
            Quote randomQuote = movie.Quotes.ElementAt(randomIndex);

            var randomQuoteDTO = new QuoteDTO
            {
                Id = randomQuote.Id,
                Actor = randomQuote.Actor.Name + ' ' + randomQuote.Actor.Surname,
                Content = randomQuote.Content,
                Year = movie.Year
            };
            return Ok(randomQuoteDTO);
        }

        /// <summary>
        /// Gets a list of dialogues taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A list of dialogues from the movie</returns>
        [HttpGet("{id}/dialogues")]
        [ProducesResponseType(typeof(DialogueDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieDialogues(int id)
        {
            _logger.LogInformation("Getting dialogues from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            ICollection<DialogueDTO> movieDialoguesDTO = MapMovieDialogues(movie);
            return Ok(movieDialoguesDTO);
        }

        /// <summary>
        /// Get a random dialogue taken from the specified movie
        /// </summary>
        /// <param name="id">Movie identifier</param>
        /// <returns>A random dialogue from the movie</returns>
        [HttpGet("{id}/dialogues/random")]
        [ProducesResponseType(typeof(DialogueDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMovieRandomDialogue(int id)
        {
            _logger.LogInformation("Getting random dialogue from movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                _logger.LogWarning("Not found movie with Id: {ID} @ {DATE}", id, DateTime.UtcNow);
                return NotFound();
            }

            var random = new Random(Guid.NewGuid().GetHashCode());
            var randomIndex = random.Next(1, movie.Dialogues.Count);
            Dialogue randomDialogue = movie.Dialogues.ElementAt(randomIndex);

            var randomDialogueDTO = new DialogueDTO
            {
                Id = randomDialogue.Id,
                Content = randomDialogue.Content,
                Year = movie.Year
            };
            return Ok(randomDialogueDTO);
        }

        private ICollection<QuoteDTO> MapMovieQuotes(Movie movieDTO)
        {
            List<QuoteDTO> movieQuotesDTO = new List<QuoteDTO>();
            foreach (var quote in movieDTO.Quotes)
            {
                movieQuotesDTO.Add(new DTOs.QuoteDTO
                {
                    Id = quote.Id,
                    Actor = quote.Actor.Name + ' ' + quote.Actor.Surname,
                    Content = quote.Content,
                    Year = movieDTO.Year
                });
            }
            return movieQuotesDTO;
        }

        private ICollection<DialogueDTO> MapMovieDialogues(Movie movieDTO)
        {
            List<DTOs.DialogueDTO> movieDialogues = new List<DialogueDTO>();
            foreach (var dialogueDTO in movieDTO.Dialogues)
            {
                movieDialogues.Add(new DTOs.DialogueDTO
                {
                    Id = dialogueDTO.Id,
                    Content = dialogueDTO.Content,
                    Year = movieDTO.Year
                });
            }
            return movieDialogues;
        }
    }
}
