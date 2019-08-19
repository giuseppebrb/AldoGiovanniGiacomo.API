using AldoGiovanniGiacomo.API.Contexts;
using AldoGiovanniGiacomo.API.Controllers;
using AldoGiovanniGiacomo.API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AldoGiovanniGiacomo.API_Test.Controllers
{
    public class MovieControllerTest
    {
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger<MovieController> _logger;
        public MovieControllerTest()
        {
            _context = Initialize.CreateNewTestContext();
            Initialize.SeedTestDb(_context);

            _logger = Mock.Of<ILogger<MovieController>>();
        }

        [Fact]
        public async Task GetMovies_OkStatusCode_WithEmptyContext()
        {
            // Arrange
            var optionBuilder = new DbContextOptionsBuilder<AldoGiovanniGiacomoAPIContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var exmptyContext = new AldoGiovanniGiacomoAPIContext(optionBuilder.Options);
            var controller = new MovieController(exmptyContext, _logger);

            // Act
            var result = await controller.GetMovies();
            var okResult = result as OkObjectResult;
            var movies = okResult.Value as ICollection<MovieDTO>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(0, movies.Count);
        }

        [Fact]
        public async Task GetMovies_OkStatusCode_WithNOTEmptyContext()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovies();
            var okResult = result as OkObjectResult;
            var movies = okResult.Value as ICollection<MovieDTO>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(12, movies.Count);
        }

        [Fact]
        public async Task GetMovie_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovie(5);
            var okResult = result as OkObjectResult;
            var movie = okResult.Value as MovieDTO;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(5, movie.Id);
            Assert.Equal(2002, movie.Year);
            Assert.Equal("La leggenda di Al, John e Jack", movie.Title);
            Assert.Equal("Aldo Baglio, Giovanni Storti, Giacomo Poretti, Massimo Venier", movie.Director);
            Assert.Equal(11, movie.Quotes.Count);
        }

        [Fact]
        public async Task GetMovie_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovie(42);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetMovieRandomQuote_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovieRandomQuote(5);
            var okResult = result as OkObjectResult;
            var randomQuote = okResult.Value;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.IsType<QuoteDTO>(randomQuote);
        }

        [Fact]
        public async Task GetMovieRandomQuote_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovieRandomQuote(42);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetMovieQuotes_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovieQuotes(5);
            var okResult = result as OkObjectResult;
            var quotes = okResult.Value as ICollection<QuoteDTO>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(11, quotes.Count);
        }

        [Fact]
        public async Task GetMovieDialogues_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovieDialogues(5);
            var okResult = result as OkObjectResult;
            var dialogues = okResult.Value as ICollection<DialogueDTO>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(11, dialogues.Count);
        }

        [Fact]
        public async Task GetMovieRandomDialogue_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new MovieController(_context, _logger);

            // Act
            var result = await controller.GetMovieRandomDialogue(5);
            var okResult = result as OkObjectResult;
            var dialogue = okResult.Value;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.IsType<DialogueDTO>(dialogue);
        }
    }
}
