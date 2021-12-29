using BackEndHomeTask3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndHomeTask3.ViewModels
{
    public class PortfolioViewModel
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<Client> Clients { get; set; }

        public List<PortDetails>PortDetails {get; set;}
    }
}
