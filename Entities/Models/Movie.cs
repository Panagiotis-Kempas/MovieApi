﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Title is mandatory"), MaxLength(60), MinLength(2)]
        public string Title { get; set; }
        [Required, Range(0, 10)]
        public double Rating { get; set; }
        public Country Country { get; set; }
        [Required]
        [Display(Name = "Production Year")]
        public DateTime ProductionYear { get; set; }
        [Required, Range(0, 1200)]
        public int Duration { get; set; }  //Minutes
        [Display(Name = "Image")]
        public string PhotoUrl { get; set; }
        [Display(Name = "Trailer")]
        public string TrailerUrl { get; set; }
        public double? Price { get; set; }
        [Display(Name = "I've watched it!")]
        public bool Watched { get; set; }


        //Navigation Properties
        public  ICollection<ActorMovie> ActorMovies { get; set; }
        public int DirectorId { get; set; }
        public  Director Director { get; set; }

        public int? GenreId { get; set; }
        public  Genre Genre { get; set; }
    }
}
