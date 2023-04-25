using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TemplateSetupTask.DataAccess;
using TemplateSetupTask.DataAccess;
using TemplateSetupTask.Models;
using TemplateSetupTask.ViewModels;

namespace TemplateSetupTask.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DataContext _context;

        public ServiceController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();
            return View(services);
        }
        public IActionResult Detail(int id)
        {
            Service srv = _context.Services.Find(id);

            if (srv == null)
                return View("Error");


            return View(srv);
           
        }
    }
}
