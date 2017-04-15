using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace briggs_Reviews.Models
{
    public enum MovieRating
    {
        A,
        B,
        C,
        D,
        F
    }
    public class Review
    {
        public string Content { get; set; }

        public int ID { get; set; }

        [Display(Name = "Date Created")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        public MovieRating Rating { get; set; }
    }
}