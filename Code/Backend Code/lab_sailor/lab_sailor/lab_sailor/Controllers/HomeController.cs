using lab_sailor.Models;
using lab_sailor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_sailor.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Slider> slider = new List<Slider>
            {
                new Slider{ID=1,Title="Welcome to Sailor",Content="Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",ImageName="slide-1.jpg"},
                new Slider{ID=2,Title="Welcome to Sailor 2",Content="Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",ImageName="slide-2.jpg"},
                new Slider{ID=3,Title="Welcome to Sailor 3",Content="Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",ImageName="slide-3.jpg"},
            };

            List<Services> services = new List<Services>
            {
                new Services{ID=1,Title="Services-1",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-briefcase"},
                new Services{ID=2,Title="Services-2",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-card-checklist"},
                new Services{ID=3,Title="Services-3",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-bar-chart"},
                new Services{ID=4,Title="Services-4",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-binoculars"},
                new Services{ID=5,Title="Services-5",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-brightness-high"},
                new Services{ID=6,Title="Services-6",Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",IconName="bi bi-calendar4-week"},
            };

            HomeViewModel homeVM = new HomeViewModel
            {
                Slider=slider,
                Services=services
            };
            return View(homeVM);
        }
    }
}