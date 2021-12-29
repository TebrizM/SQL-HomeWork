using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndHomeTask3.Models;

namespace BackEndHomeTask3.ViewModels
{
    public class AboutViewModel
    {
        public List<Count> Counts { get; set; }
        public List<Client> Clients { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}
