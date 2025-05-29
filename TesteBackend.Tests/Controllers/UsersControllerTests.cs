using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteBackend.Controllers;
using TesteBackend.Api.Models;
using TesteBackend.Data;
using TesteBackend.Api.Controllers;
using TesteBackend.Api.Data;

namespace TesteBackend.Tests.Controllers
{
    public class UsersControllerTests
    {
        private AppDbContext GetInMemoryDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            var context = new AppDbContext(options);

            context.Users.Add(new User { Nome = "Teste", Email = "teste@email.com", Telefone = "123" });
            context.SaveChanges();

            return context;
        }

        [Fact]
        public async Task GetUsers_ReturnsList()
        {
            var context = GetInMemoryDbContext();
            var controller = new UsersController(context);

            var result = await controller.GetUsers();

            var actionResult = Assert.IsType<ActionResult<IEnumerable<User>>>(result);
            var users = Assert.IsAssignableFrom<IEnumerable<User>>(actionResult.Value);
            Assert.Single(users);

        }
    }
}

