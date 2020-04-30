using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCars.Web.Models
{
    public class NewCarRequest
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public string Price { get; set; }
        public string DateMade { get; set; }
        public string Mileage { get; set; }
    }
}
