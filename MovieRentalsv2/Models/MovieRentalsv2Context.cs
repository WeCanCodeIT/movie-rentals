using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieRentalsv2.Models
{
    public class MovieRentalsv2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MovieRentalsv2Context() : base("name=MovieRentalsv2Context")
        {
        }

        public DbSet<MovieRentalsv2.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<MovieRentalsv2.Models.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<MovieRentalsv2.Models.Rental> Rentals { get; set; }
    }
}
