using BackEndHomeTask3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndHomeTask3.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Slider { get; set; }
        public List<Featured> Featured { get; set; }
        public List<Service> Services { get; set; }
     public List<Client> Clients { get; set; }
        
    }

}
