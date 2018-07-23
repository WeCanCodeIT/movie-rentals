using System.Collections.Generic;

namespace MovieRentalsv2.Models
{
    public class CustomerSearchViewModel
    {
        public string SearchText { get; set; }
        public List<Customer> Results { get; set; }
    }
}