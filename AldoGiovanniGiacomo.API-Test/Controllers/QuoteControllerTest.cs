using AldoGiovanniGiacomo.API.Contexts;
using AldoGiovanniGiacomo.API.Controllers;
using AldoGiovanniGiacomo.API.Models;
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
    public class QuoteControllerTest
    {
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger<QuoteController> _logger;
        public QuoteControllerTest()
        {
            _context = Initialize.CreateNewTestContext();
            Initialize.SeedTestDb(_context);

            _logger = Mock.Of<ILogger<QuoteController>>();
        }

        [Fact]
        public async Task GetQuotes_OkStatusCode_WithEmptyContext()
        {
            // Arrange
            var optionBuilder = new DbContextOptionsBuilder<AldoGiovanniGiacomoAPIContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var exmptyContext = new AldoGiovanniGiacomoAPIContext(optionBuilder.Options);
            var controller = new QuoteController(exmptyContext, _logger);

            // Act
            var result = await controller.GetQuotes();
            var okResult = result as OkObjectResult;
            var quotes = okResult.Value as ICollection<Quote>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(0, quotes.Count);
        }

        [Fact]
        public async Task GetQuotes_OkStatusCode_WithNOTEmptyContext()
        {
            // Arrange
            var controller = new QuoteController(_context, _logger);

            // Act
            var result = await controller.GetQuotes();
            var okResult = result as OkObjectResult;
            var quotes = okResult.Value as ICollection<Quote>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(11, quotes.Count);
        }

        [Fact]
        public async Task GetQuote_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new QuoteController(_context, _logger);

            // Act
            var result = await controller.GetQuote(1);
            var okResult = result as OkObjectResult;
            var quote = okResult.Value as Quote;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal("Aldo Baglio", quote.Actor);
            Assert.Equal("E voi chi minchia siete?", quote.Content);
            Assert.Equal("La leggenda di Al, John e Jack", quote.Movie);
            Assert.Equal(2002, quote.Year);
        }

        [Fact]
        public async Task GetQuote_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var controller = new QuoteController(_context, _logger);

            // Act
            var result = await controller.GetQuote(12);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetRandomQuote_OkStatusCode()
        {
            // Arrange
            var controller = new QuoteController(_context, _logger);

            // Act
            var result = await controller.GetRandomQuote();
            var okResult = result as OkObjectResult;
            var randomQuote = okResult.Value as Quote;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.IsType<Quote>(randomQuote);
        }
    }
}
