using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppServer.BAL.Interfaces;
using MovieAppServer.DAL.Interfaces;
using MovieAppServer.Models;

namespace MovieAppServer.BAL.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> carRepo;

        public CarService(IRepository<Car> carRepo)
        {
            this.carRepo = carRepo;
        }
        public IEnumerable<Car> GetCars()
        {
            return carRepo.GetAll();
        }

        public Car GetCarById(Guid id)
        {
            return carRepo.Get(id);
        }
    }
}
