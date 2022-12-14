using System;
namespace BookingManagerLibrary.Models
{
    public sealed class Employee
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
    }
}

