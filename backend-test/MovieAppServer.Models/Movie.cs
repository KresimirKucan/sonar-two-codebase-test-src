using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppServer.Models
{
    public class Movie : BaseModel
    {
        public string? Title { get; set; }
        public double Score { get; set; }
        public string? Description { get; set; }
        public string? Language { get; set; }
    }
}
