using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProjectStarter.Models
{
    public class Song
    {
        public int id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string title { get; set; }

        
        public string artist { get; set; }
        public string album { get; set; }

        [Display(Name = " Category of Music")]
        [Required]
        public string genre { get; set; }
        //annotation

        [Display(Name = " Release Date")]
        [DataType(DataType.Date)]
        public DateTime releaseDate { get; set; }

    }
}
