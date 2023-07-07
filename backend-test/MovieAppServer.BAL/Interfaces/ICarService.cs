using MovieAppServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppServer.BAL.Interfaces
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(Guid id);
    }
}
