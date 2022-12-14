using System;
namespace BookingManagerLibrary.Models
{
    public sealed class TripEvent
    {
        public int EventId { get; set; }
        public Address Location { get; set; }
        public EventType Type { get; set; }
        public EventStatus Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Requirements { get; set; }
        public List<Expense> TripCosts { get; set; }

        public TimeSpan Duration => EndDate - StartDate;

        public bool IsValid()
        {
            return Location != null
                && !String.IsNullOrEmpty(Title)
                && !String.IsNullOrEmpty(Description)
                && EndDate > StartDate;
        }
    }
}

