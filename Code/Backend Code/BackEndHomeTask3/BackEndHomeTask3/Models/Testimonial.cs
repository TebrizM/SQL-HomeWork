﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndHomeTask3.Models
{
    public class Testimonial
    {
        public int ID {get;set;}
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Content { get; set; }
    }
}
