using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieAppServer.DAL.Extensions;
using MovieAppServer.Models;

namespace MovieAppServer.DAL.Data
{
    public class MovieAppDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public MovieAppDbContext(
            DbContextOptions<MovieAppDbContext> options,
            IConfiguration configuration)
            : base(options)
        {
            this.configuration = configuration;
        }


        public DbSet<Movie> Movies => Set<Movie>();


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MovieAppDb"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieAppDbContext).Assembly);

            // seeding...
            modelBuilder.Seed();
        }

    }
}
