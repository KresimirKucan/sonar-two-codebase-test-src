using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieAppServer.DAL.Data;
using MovieAppServer.DAL.Interfaces;
using MovieAppServer.Models;

namespace MovieAppServer.DAL.Services
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly MovieAppDbContext dbContext;

        public Repository(MovieAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().AsNoTracking().ToList();
        }

        public T Get(Guid id)
        {
            var item = dbContext.Set<T>().FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                return null;
            }

            return item;
        }
    }
}
