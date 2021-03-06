﻿using GoodCars.Data.Models;
using System.Collections.Generic;

namespace GoodCars.Services
{
    public interface ICar
    {
        public void AddCar(Car car);
        public void DeleteCar(int id);
        public List<Car> GetAll();
        public Car GetById(int id);

        public void AddCarOwner(CarOwner owner);
        public List<CarOwner> GetAllOwners();
        public CarOwner GetOwnerById(int id);
    }
}
