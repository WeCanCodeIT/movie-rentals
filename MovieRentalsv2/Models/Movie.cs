using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalsv2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}