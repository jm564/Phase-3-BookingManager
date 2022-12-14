using System;
using BookingService.Models;

namespace BookingManagerLibrary.Models
{
    public sealed class Reservation
    {
        public int ReservationId { get; set; }
        public int EventId { get; set; }
        public string ConfirmationCode { get; set; }
        public ReservationStatus reservationStatus {get;set;}

        public bool IsValid()
        {
            return EventId > 0;
        }
    }
}

