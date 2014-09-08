namespace MovieManager.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MovieManagerContext : DbContext
    {
        // Your context has been configured to use a 'MovieManager' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MovieManager.Models.MovieManager' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MovieManager' 
        // connection string in the application configuration file.
        public MovieManagerContext()
            : base("name=MovieManager")
        {
            Database.SetInitializer<MovieManagerContext>(new DataInitializer());

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Movie> Movies { get; set; }

         public System.Data.Entity.DbSet<MovieManager.Models.Director> Directors { get; set; }

         public System.Data.Entity.DbSet<MovieManager.Models.Actor> Actors { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}