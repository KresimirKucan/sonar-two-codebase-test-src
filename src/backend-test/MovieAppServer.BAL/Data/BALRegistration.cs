using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppServer.BAL.Interfaces;
using MovieAppServer.BAL.Services;

namespace MovieAppServer.BAL.Data
{
    public static class BALRegistration
    {
        public static IServiceCollection AddBALServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieService,MovieService>();
            services.AddScoped<ICarService,CarService>();

            return services;
        }

    }
}
