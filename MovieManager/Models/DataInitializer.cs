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
            context.Directors.Add(new Director() {FirstName = "Steven",LastName = "Spielberg"});
            base.Seed(context);
        }
    }
}