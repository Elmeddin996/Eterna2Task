using System.Collections.Generic;
using TemplateSetupTask.Models;

namespace TemplateSetupTask.DataAccess
{
    public static class Data
    {
        public static List<Feature> Features = new List<Feature>
        {
            new Feature{Id=1,Title="Lorem 1",Icon="bi bi-card-checklist",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature{Id=2,Title="Lorem 2",Icon="bi bi-bar-chart",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new Feature{Id=3,Title="Lorem 3",Icon="bi bi-binoculars",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"}
        };

        public static List<Service> Services = new List<Service>
        {
            new Service{Id=1, Title="Service 1", Icon="bx bxl-dribbble", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore" },
            new Service{Id=2, Title="Service 2", Icon="bx bx-file", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore" },
            new Service{Id=3, Title="Service 3", Icon="bx bx-tachometer", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore" },
            new Service{Id=4, Title="Service 4", Icon="bx bx-world", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore" },
            new Service{Id=5, Title="Service 5", Icon="bx bx-slideshow", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore" },
            new Service{Id=6, Title="Service 6", Icon="bx bx-arch", Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore" }
        };
    }
}
    