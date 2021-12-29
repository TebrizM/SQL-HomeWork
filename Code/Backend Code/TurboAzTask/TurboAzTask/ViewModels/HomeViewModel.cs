using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAzTask.Models;
namespace TurboAzTask.ViewModels
{
    public class HomeViewModel
    {
        public List<Car> Cars { get; set; }
        public List<Model> Models { get; set; }
        public List<Brand> Brands { get; set; }
        public List<CarImages> Images { get; set; }
    }
}
