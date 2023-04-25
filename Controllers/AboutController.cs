 using Microsoft.AspNetCore.Mvc;

namespace TemplateSetupTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
