using Microsoft.Extensions.Logging;
using Moq;
using Vaquinha.Domain;
using Vaquinha.MVC.Controllers;

namespace Vaquinha.Unit.Tests.ControllerTests
{
    public class HomeControllerTests
    {
        private readonly IHomeInfoService _homeInfoService;
        private Mock<ILogger<HomeController>> _logger;

        public HomeControllerTests()
        {

        }
    }
}
