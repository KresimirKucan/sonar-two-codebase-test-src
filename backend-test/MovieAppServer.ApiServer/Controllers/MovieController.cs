using Microsoft.AspNetCore.Mvc;
using MovieAppServer.BAL.Interfaces;
using MovieAppServer.Models;

namespace MovieAppServer.ApiServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService movieService;

        public MovieController(IMovieService movieServ)
        {
            this.movieService = movieServ;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            var movies = movieService.GetMovies();
            return Ok(movies);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<Movie> GetById(Guid id)
        {
            var movie = movieService.GetMovieById(id);
            if (movie == null)
            {
                return BadRequest($"Movie with Id = {id} does not exist.");

            }
            return Ok(movie);
        }
    }
}
