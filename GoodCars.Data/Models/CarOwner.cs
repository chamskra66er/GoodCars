﻿
namespace GoodCars.Data.Models
{
    public class CarOwner
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public double Period { get; set; }
        public string Owner { get; set; }
        public string OwnerContent { get; set; }

    }
}
