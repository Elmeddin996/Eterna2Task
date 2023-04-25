using Microsoft.AspNetCore.Mvc;

namespace TemplateSetupTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
