using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MovieAppServer.DAL.Interfaces;
using MovieAppServer.DAL.Services;

namespace MovieAppServer.DAL.Data
{
    public static class DALRegistration
    {
        public static IServiceCollection AddDALServices(this IServiceCollection services)
        {
            services.AddDbContext<MovieAppDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
