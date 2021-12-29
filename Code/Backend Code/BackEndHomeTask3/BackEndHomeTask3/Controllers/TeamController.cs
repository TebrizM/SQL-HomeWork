using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndHomeTask3.Models;

namespace BackEndHomeTask3.Controllers
{
    public class TeamController : Controller
    {

        private readonly List<Team> _teams;
        public TeamController()
        {
            _teams = new List<Team>
            {
                new Team {ID=1, Title="Walter White", Position="Chief Executive Officer", Content="Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut",Image="team-1.jpg"},
                new Team {ID=2, Title="Sarah Jhinson", Position="Product Manager", Content=" Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus",Image="team-2.jpg"},
                new Team {ID=3, Title="William Anderson", Position="CTO", Content="Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara",Image="team-3.jpg"},
            };
        }
        public IActionResult Index()
        {
            return View(_teams);
        }
        public IActionResult Details(int id)
        {
          var item = _teams.Find(x => x.ID == id);

            if (item == null)
            {
                TempData["Error"] = "This Team Member is not Exist!";
                return RedirectToAction("Error");
            }

            return View(item);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
