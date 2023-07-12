using Microsoft.AspNetCore.Mvc;
using MovieAppServer.BAL.Interfaces;
using MovieAppServer.Models;

namespace MovieAppServer.ApiServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;

        public CarController(ICarService movieServ)
        {
            this.carService = movieServ;
        }
         
        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<Car>> Get()
        {
            var cars = carService.GetCars();
            return Ok(cars);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<Car> GetById(Guid id)
        {
            var car = carService.GetCarById(id);
            if (car == null)
            {
                return BadRequest($"Car with Id = {id} does not exist.");

            }

            return Ok(car);
        }
    }
}
