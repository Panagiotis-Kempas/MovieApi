using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public double Rating { get; set; }
        public Country Country { get; set; }
       
        public DateTime ProductionYear { get; set; }
       
        public int Duration { get; set; }  //Minutes
       
        public string PhotoUrl { get; set; }
       
        public string TrailerUrl { get; set; }
        public double? Price { get; set; }
       
        public bool Watched { get; set; }
    }
}
