using System.Collections.Generic;
using TemplateSetupTask.Models;

namespace TemplateSetupTask.ViewModels
{
    public class ViewModel
    {
        public List<Feature> Features { get; set; }
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
    }
}
