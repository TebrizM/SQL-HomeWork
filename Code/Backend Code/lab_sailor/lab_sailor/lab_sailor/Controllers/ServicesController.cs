using lab_sailor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_sailor.Controllers
{
    public class ServicesController : Controller
    {
        private readonly List<Services> _services;
        public ServicesController()
        {
            _services = new List<Services>
            {
                new Services{ID=1,Title="Services-1",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-briefcase"},
                new Services{ID=2,Title="Services-2",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-card-checklist"},
                new Services{ID=3,Title="Services-3",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-bar-chart"},
                new Services{ID=4,Title="Services-4",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-binoculars"},
                new Services{ID=5,Title="Services-5",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-brightness-high"},
                new Services{ID=6,Title="Services-6",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-calendar4-week"},
            };
        }
        public IActionResult Index()
        {
            return View(_services);
        }
        public IActionResult Detail(int id)
        {
            var services = _services.Find(x => x.ID == id);
            return View(services);
        }
    }
}