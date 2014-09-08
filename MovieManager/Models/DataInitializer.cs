using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieManager.Models
{
    public class DataInitializer:DropCreateDatabaseAlways<MovieManagerContext>
    {
        protected override void Seed(MovieManagerContext context)
        {
            var director1 = new Director() {FirstName = "Steven", LastName = "Spielberg"};
            var director2 = new Director() {FirstName = "Rian", LastName = "Johnson"};
            var movie1 = new Movie {Title = "Jurassic Park", YearReleased = "1993", Director = director1};
            var movie2 = new Movie() {Title = "The Terminal", YearReleased = "1994", Director = director1};
            var movie3 = new Movie() {Title = "Brick", YearReleased = "2005", Director = director2};
            context.Movies.Add(movie1);
            context.Movies.Add(movie2);
            context.Movies.Add(movie3);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}