using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCars.Services
{
    public interface IBook
    {
        public void AddCar(Car car);
        public void DeleteCar(int id);
        public List<Car> GetAll();
        public Car GetById(int id);
    }
}
