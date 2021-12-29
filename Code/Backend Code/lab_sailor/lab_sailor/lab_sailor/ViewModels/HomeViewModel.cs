using lab_sailor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_sailor.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Slider { get; set; }
        public List<Services> Services { get; set; }
    }
}