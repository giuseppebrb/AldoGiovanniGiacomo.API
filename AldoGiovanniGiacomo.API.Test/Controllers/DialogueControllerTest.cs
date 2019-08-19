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
    public class DialogueControllerTest
    {
        private readonly AldoGiovanniGiacomoAPIContext _context;
        private readonly ILogger<DialogueController> _logger;
        public DialogueControllerTest()
        {
            _context = Initialize.CreateNewTestContext();
            Initialize.SeedTestDb(_context);

            _logger = Mock.Of<ILogger<DialogueController>>();
        }

        [Fact]
        public async Task GetDialogues_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var optionBuilder = new DbContextOptionsBuilder<AldoGiovanniGiacomoAPIContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            var exmptyContext = new AldoGiovanniGiacomoAPIContext(optionBuilder.Options);
            var controller = new DialogueController(exmptyContext, _logger);

            // Act
            var result = await controller.GetDialogues();
            var okResult = result as OkObjectResult;
            var dialogues = okResult.Value as ICollection<Dialogue>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(0, dialogues.Count);
        }

        [Fact]
        public async Task GetDialogues_OkStatusCode_WithNOTEmptyContext()
        {
            // Arrange
            var controller = new DialogueController(_context, _logger);

            // Act
            var result = await controller.GetDialogues();
            var okResult = result as OkObjectResult;
            var dialogues = okResult.Value as ICollection<Dialogue>;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(11, dialogues.Count);
        }

        [Fact]
        public async Task GetDialogue_OkStatusCode_WithValidId()
        {
            // Arrange
            var controller = new DialogueController(_context, _logger);

            // Act
            var result = await controller.GetDialogue(1);
            var okResult = result as OkObjectResult;
            var dialogue = okResult.Value as Dialogue;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.Equal(1, dialogue.Id);
            Assert.Equal("John: Che stai facendo, Jack? Che stai facendo?\nJack: Johnny... Smarties contro Anfetamine, no? [si vedono appunto degli Smarties e delle pasticche di anfetamine disposti su una scacchiera]\nJohn: E ti sembra il momento?\nJack: È sempre il momento!\nJohn [esegue alcune mosse per far concludere la partita]: Partita finita.", dialogue.Content);
            Assert.Equal("La leggenda di Al, John e Jack", dialogue.Movie);
            Assert.Equal(2002, dialogue.Year);
        }

        [Fact]
        public async Task GetDialogue_NotFoundStatusCode_WithInvalidId()
        {
            // Arrange
            var controller = new DialogueController(_context, _logger);

            // Act
            var result = await controller.GetDialogue(42);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetRandomDialogue_OkStatusCode()
        {
            // Arrange
            var controller = new DialogueController(_context, _logger);

            // Act
            var result = await controller.GetRandomDialogue();
            var okResult = result as OkObjectResult;
            var randomDialogue = okResult.Value;

            //Assert
            Assert.NotNull(okResult);
            Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
            Assert.IsType<Dialogue>(randomDialogue);
        }
    }
}
