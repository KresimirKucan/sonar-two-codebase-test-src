using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppServer.Models
{
    public class Car : BaseModel
    {
        public string? Brand { get; set; }
        public int HorsePower { get; set; }
        public int Year { get; set; }
        public int Kilometer { get; set; }
    }
}
