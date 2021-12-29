using BackEndHomeTask3.Models;
using BackEndHomeTask3.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackEndHomeTask3.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Slider> _slider;

        private readonly List<Featured> _featured;

        private readonly List<Service> _services;

        private readonly List<Client> _clients;

        private readonly List<Count> _counts;
        
        private readonly List<Testimonial> _testimonials;

        public HomeController()
        {
            _slider = new List<Slider>
            {
                new Slider{ID=1,Title="Welcome to", Title2="Eterna", Content="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",ImageName="slide-1.jpg"},
                new Slider{ID=2,Title="Lorem", Title2="Ipsum Dolor", Content="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",ImageName="slide-2.jpg"},
                new Slider{ID=3,Title="Sequi ea", Title2="Dime Lara", Content="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",ImageName="slide-3.jpg"},
            };

            _featured = new List<Featured>
            {
                new Featured {ID=1, Title="Lorem Ipsum", Icon="bi bi-card-checklist", Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
                new Featured {ID=2, Title="Dolor Sitema", Icon="bi bi-bar-chart", Content="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"},
                new Featured {ID=3, Title="Sed ut perspiciatis", Icon="bi bi-binoculars", Content="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"}
            };

            _services = new List<Service>
            {
                new Service{ID=1, Title="Lorem Ipsum", Icon="bx bxl-dribbble", Content="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
                new Service{ID=2, Title="Sed ut perspiciatis", Icon="bx bx-file", Content="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
                new Service{ID=3, Title="Magni Dolores", Icon="bx bx-tachometer", Content="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
                new Service{ID=4, Title="Nemo Enim", Icon="bx bx-world", Content="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
                new Service{ID=5, Title="Dele cardo", Icon="bx bx-slideshow", Content="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
                new Service{ID=6, Title="Divera don", Icon="bx bx-arch", Content="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"}
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

            _counts = new List<Count>
            {
                new Count{ID=1,  Icons="bi bi-emoji-smile", Title1="Happy Clients", Title2="consequuntur quae qui deca rode"},
                new Count{ID=2,  Icons="bi bi-journal-richtext", Title1="Projects", Title2="adipisci atque cum quia aut numquam delectus"},
                new Count{ID=3,  Icons="bi bi-headset", Title1="Hours Of Support", Title2="aut commodi quaerat. Aliquam ratione"},
                new Count{ID=4,  Icons="bi bi-people", Title1="Hard Workers", Title2="rerum asperiores dolor molestiae doloribu"}
            };

            _testimonials = new List<Testimonial>
            {
                new Testimonial {ID=1, Name="Saul Goodman", Position="Ceo & Founder", Content="Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.", Image="testimonials-1.jpg"},
                new Testimonial {ID=2, Name="Sara Wilsson", Position="Designer", Content="Export tempor illum tamen malis malis eram quae irure esse labore quem cillum quid cillum eram malis quorum velit fore eram velit sunt aliqua noster fugiat irure amet legam anim culpa.", Image="testimonials-2.jpg"},
                new Testimonial {ID=3, Name="Jena Karlis", Position="Store Owner", Content="Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.", Image="testimonials-3.jpg"},
                new Testimonial {ID=4, Name="Matt Brandon", Position="Freelancer", Content="Fugiat enim eram quae cillum dolore dolor amet nulla culpa multos export minim fugiat minim velit minim dolor enim duis veniam ipsum anim magna sunt elit fore quem dolore labore illum veniam.", Image="testimonials-4.jpg"},
                new Testimonial {ID=5, Name="John Larson", Position="Entrepreneur", Content="Quis quorum aliqua sint quem legam fore sunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid.", Image="testimonials-5.jpg"},
                new Testimonial {ID=6, Name="Emily Harison", Position="Store Owner", Content="Eius ipsam praesentium dolor quaerat inventore rerum odio. Quos laudantium adipisci eius. Accusamus qui iste cupiditate sed temporibus est aspernatur. Sequi officiis ea et quia quidem.", Image="testimonials-6.jpg"}
            };
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Slider = _slider,
                Featured = _featured,
                Services = _services,
                Clients = _clients
            };
            return View(homeVM);
            
        }
        public IActionResult About()
        {
            AboutViewModel aboutVM = new AboutViewModel
            {
                Counts = _counts,
                Clients = _clients,
                Testimonials = _testimonials
            };

            return View(aboutVM);
        }
        public IActionResult Services()
        {
            return View(_services);
        }
    }
}
