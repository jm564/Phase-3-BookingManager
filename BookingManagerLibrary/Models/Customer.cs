using System;
namespace BookingManagerLibrary.Models
{
    public sealed class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address CustomerAddress { get; set; }
        public string Phone { get; set; }
    }
}

