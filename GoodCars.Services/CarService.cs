using GoodCars.Data.Models;
using System;
using GoodCars.Data;
using System.Collections.Generic;
using System.Linq;

namespace GoodCars.Services
{
    public class CarService : ICar
    {
        private readonly ApplicationDbContext _context;
        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddCar(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var model = GetById(id);
            if (model!=null)
            {
                _context.Remove(model);
                _context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Can't delete car that doesn't exists");
            }
        }

        public List<Car> GetAll() => 
            _context.Cars.ToList();

        public Car GetById(int id) =>
            GetAll().FirstOrDefault(x=>x.Id==id);
    }
}
