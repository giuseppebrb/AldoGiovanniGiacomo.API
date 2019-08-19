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
    public class ActorControllerTest
    {
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger<ActorController> _logger;
        public ActorControllerTest()
        {
            _context = Initialize.CreateNewTestContext();
            Initialize.SeedTestDb(_context);

            _logger = Mock.Of<ILogger<ActorController>>();
        }


        [Fact]
        public async Task GetActors_OkStatusCode_WithEmptyContext()
        {
            // Arrange
            var optionBuilder = new DbContextOptionsBuilder<AldoGiovanniGiacomoAPIContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var exmptyContext = new AldoGiovanniGiacomoAPIContext(optionBuilder.Options);
            var controller = new ActorController(exmptyContext, _logger);

            // Act
            var result = await controller.GetActors();
            var okResult = result as OkObjectResult;
            var actors = okResult.Value as ICollection<Actor>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(0, actors.Count);
        }

        [Fact]
        public async Task GetActors_OkStatusCode_WithNOTEmptyContext()
        {
            // Arrange
            var controller = new ActorController(_context, _logger);

            // Act
            var result = await controller.GetActors();
            var okResult = result as OkObjectResult;
            var actors = okResult.Value as ICollection<Actor>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(3, actors.Count);
        }

        [Fact]
        public async Task GetActor_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new ActorController(_context, _logger);

            // Act
            var result = await controller.GetActor(1);
            var okResult = result as OkObjectResult;
            var actor = okResult.Value as Actor;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(1, actor.Id);
            Assert.Equal("Aldo", actor.Name);
            Assert.Equal("Baglio", actor.Surname);
            Assert.Equal("Palermo", actor.BirthPlace);
            Assert.Equal(new DateTime(1958, 9, 28), actor.Birth);
        }

        [Fact]
        public async Task GetActor_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var controller = new ActorController(_context, _logger);

            // Act
            var result = await controller.GetActor(4);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetActorQuotes_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new ActorController(_context, _logger);

            // Act
            var result = await controller.GetActorQuotes(1);
            var okResult = result as OkObjectResult;
            var quotes = okResult.Value as ICollection<Quote>;

            //Assert
            Assert.Equal(2, quotes.Count);
        }

        [Fact]
        public async Task GetActorQuotes_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var controller = new ActorController(_context, _logger);

            // Act
            var result = await controller.GetActorQuotes(4);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetRandomQuote_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new ActorController(_context, _logger);

            // Act
            var result = await controller.GetRandomQuote(1);
            var okResult = result as OkObjectResult;
            var randomQuote = okResult.Value;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.IsType<Quote>(randomQuote);
        }

        [Fact]
        public async Task GetRandomQuote_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var controller = new ActorController(_context, _logger);

            // Act
            var result = await controller.GetActorQuotes(4);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

    }
}
