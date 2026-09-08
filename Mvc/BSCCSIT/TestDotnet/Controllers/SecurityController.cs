using Microsoft.AspNetCore.Mvc;
using TestDotnet.Services;

namespace TestDotnet.Controllers
{
    public class SecurityController : Controller
    {
        private readonly ICustomLogger _logger;
        public SecurityController(ICustomLogger logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.Log("SecurityController Index action called.");
            return View();
        }
    }
}
