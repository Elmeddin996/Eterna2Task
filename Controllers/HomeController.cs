using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TemplateSetupTask.ViewModels;
using TemplateSetupTask.DataAccess;

namespace TemplateSetupTask.Controllers
{
    public class HomeController : Controller
    {

        private readonly DataContext _context;
        public HomeController(DataContext context)
        { 
            _context = context;
        }
        public IActionResult Index()
        {
            ViewModel viewModel = new ViewModel()
            {
                Features = _context.Features.ToList(),
                Services = _context.Services.ToList(),
                Sliders =_context.Sliders.ToList()

            };
            

            return View(viewModel);
        }
        public IActionResult About()
        {

            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }


    }
}
