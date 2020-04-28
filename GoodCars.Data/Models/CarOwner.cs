using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCars.Data.Models
{
    public class CarOwner
    {
        public int Id { get; set; }
        public double Period { get; set; }
        public string Owner { get; set; }
        public string OwnerContent { get; set; }
    }
}
