using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndHomeTask3.Models;
using BackEndHomeTask3.ViewModels;

namespace BackEndHomeTask3.Controllers
{
    public class PortfolioController:Controller
    {
        private readonly List<Portfolio> _portfolios;
        private readonly List<Client> _clients;
        public readonly List<PortDetails> _portDetails;
        public PortfolioController()
        {
            _portDetails = new List<PortDetails>
            {
                new PortDetails {ID=1, Image="portfolio-1.jpg"},
                new PortDetails {ID=2, Image="portfolio-2.jpg"},
                new PortDetails {ID=3, Image="portfolio-3.jpg"},
                new PortDetails {ID=4, Image="portfolio-4.jpg"},
                new PortDetails {ID=5, Image="portfolio-5.jpg"},
                new PortDetails {ID=6, Image="portfolio-6.jpg"},
                new PortDetails {ID=7, Image="portfolio-7.jpg"},
                new PortDetails {ID=8, Image="portfolio-8.jpg"},
                new PortDetails {ID=9, Image="portfolio-9.jpg"}
            };
            _clients = new List<Client>
            {
                new Client{ID=1, Imageurl="client-1.png"},
                new Client{ID=2, Imageurl="client-2.png"},
                new Client{ID=3, Imageurl="client-3.png"},
                new Client{ID=4, Imageurl="client-4.png"},
                new Client{ID=5, Imageurl="client-5.png"},
                new Client{ID=6, Imageurl="client-6.png"},
                new Client{ID=7, Imageurl="client-7.png"},
                new Client{ID=8, Imageurl="client-8.png"}
            };
            _portfolios = new List<Portfolio>
            {
                new Portfolio {ID=1, Title="App 1", Title2="App", Image="portfolio-1.jpg"},
                new Portfolio {ID=2, Title="Web 3", Title2="Web", Image="portfolio-2.jpg"},
                new Portfolio {ID=3, Title="App 2", Title2="App", Image="portfolio-3.jpg"},
                new Portfolio {ID=4, Title="Card 2", Title2="Card", Image="portfolio-4.jpg"},
                new Portfolio {ID=5, Title="Web 2", Title2="Web", Image="portfolio-5.jpg"},
                new Portfolio {ID=6, Title="App 3", Title2="App", Image="portfolio-6.jpg"},
                new Portfolio {ID=7, Title="Card 1", Title2="Card", Image="portfolio-7.jpg"},
                new Portfolio {ID=8, Title="Card 3", Title2="Card", Image="portfolio-8.jpg"},
                new Portfolio {ID=9, Title="Web 3", Title2="Web", Image="portfolio-9.jpg"},
            };
        }
        public IActionResult Index()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel
            {
                Clients = _clients,
                Portfolios = _portfolios,
                
                
            };

            return View(portfolioVM);
        }
        public IActionResult Detail()
        {
           


            return View(_portDetails);
        }
        
    }
}
