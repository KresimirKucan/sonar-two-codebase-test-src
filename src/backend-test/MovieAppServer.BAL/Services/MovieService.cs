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
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> movieRepo;

        public MovieService(IRepository<Movie> movieRepo)
        {
            this.movieRepo = movieRepo;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return movieRepo.GetAll();
        }

        public Movie GetMovieById(Guid id)
        {
            return movieRepo.Get(id);
        }
    }
}
