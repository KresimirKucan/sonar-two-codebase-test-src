using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppServer.Models;

namespace MovieAppServer.DAL.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car()
                {
                    Id = Guid.NewGuid(),
                    Brand = "BMW",
                    HorsePower = 190,
                    Kilometer = 103000,
                    Year = 2016
                },
                new Car()
                {
                    Id = Guid.NewGuid(),
                    Brand = "Audi",
                    HorsePower = 150,
                    Kilometer = 300000,
                    Year = 2015
                }
            );
        }
    }
}
