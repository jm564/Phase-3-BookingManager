using System;
namespace BookingManagerLibrary.Models
{
    public sealed class Trip
    {

        public List<TripEvent> Events { get; set; }
        public List<Customer> Participants { get; set; }
        public int TripId { get; set; }
        public string TripTitle { get; set; }
        public string TripDescription { get; set; }
        public Customer BookedByCustomer { get; set; }
        public Employee Agent { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TimeSpan Duration => EndDate - StartDate;
    }

    public sealed class CreateTripRequest
    {
        public string TripTitle { get; set; }
        public string TripDescription { get; set; }
        public int BookedByCustomer { get; set; }
        public int Agent { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsValid()
        {
            return !String.IsNullOrEmpty(TripTitle)
                && !String.IsNullOrEmpty(TripDescription)
                && EndDate > StartDate;
        }
    }
}

