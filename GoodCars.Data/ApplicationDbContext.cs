using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GoodCars.Data.Models;

namespace GoodCars.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options) : base(options){}

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarOwner> CarOwners { get; set; }
    }
}
