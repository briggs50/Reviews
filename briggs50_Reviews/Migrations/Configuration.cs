namespace briggs50_Reviews.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<briggs50_Reviews.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(briggs50_Reviews.Models.ApplicationDbContext context)
        {

            context.Movies.AddOrUpdate(b => b.Title,
                  new Movie
                  {
                      Id = 1,
                      Title = "American Sniper",
                      Year = 2014,
                      Category = "Action",
                      LeadingActor = "Bradley Cooper",
                      Director = "Clint Eastwood",
                      Rating = MovieRating.D

                  },
                   new Movie
                   {
                       Id = 2,
                       Title = "The Princess Bride",
                       Year = 1987,
                       Category = "Fantasy",
                       LeadingActor = "Cary Elwes",
                       Director = "Rob Reiner",
                       Rating = MovieRating.C,
                   },
                   new Movie
                   {
                       Id = 3,
                       Title = "10 Things I Hate About You",
                       Year = 1999,
                       Category = "Comedy",
                       LeadingActor = "Heath Ledger",
                       Director = "Gil Junger",
                       Rating = MovieRating.A
                   },
                   new Movie
                   {
                       Id = 4,
                       Title = "The Little Mermaid",
                       Year = 1989,
                       Category = "Animation",
                       LeadingActor = "Jodi Benson",
                       Director = "Ron Clements",
                       Rating = MovieRating.B

                   },
                    new Movie
                    {
                        Id = 5,
                        Title = "Hidden Figures",
                        Year = 2016,
                        Category = "Biography",
                        LeadingActor = "Teraji P. Henson",
                        Director = "Theodore Melfi",
                        Rating = MovieRating.A
                    }
                  );
        }
    }
}
