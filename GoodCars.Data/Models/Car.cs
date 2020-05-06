
using System.Collections.Generic;

namespace GoodCars.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public string Price { get; set; }
        public string DateMade { get; set; }
        public string Mileage { get; set; }
        public IEnumerable<CarOwner> carOwners { get; set; }

    }
}
