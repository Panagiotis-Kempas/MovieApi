using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        [Display(Name = "Photo URL")]
        public string Url { get; set; }

        // Foreign key(Actors)
        public int ActorId { get; set; }

        //Navigation Properties
        public  Actor? Actor { get; set; }
    }
}
