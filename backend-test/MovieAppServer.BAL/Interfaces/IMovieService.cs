using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppServer.Models;

namespace MovieAppServer.BAL.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieById(Guid id);
    }
}
