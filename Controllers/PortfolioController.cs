using Microsoft.AspNetCore.Mvc;

namespace EternaAddedPortofilo.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
