using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace briggs_Reviews.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Display(Name = "ReleaseDate")]
        [DataType(DataType.Date)]
        public int Year { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string LeadingActor { get; set; }

        [Required]
        public string Director { get; set; }

        public string MoviePoster { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public MovieRating Rating { get; set; }
    }
}