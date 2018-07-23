using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalsv2.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }        

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }        

        public DateTime RentalDate { get; set; }

    }
}