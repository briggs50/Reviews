using System;
using System.Collections.Generic;
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

        public string MovieTitle { get; set; }

        public MovieRating Rating { get; set; }
    }
}