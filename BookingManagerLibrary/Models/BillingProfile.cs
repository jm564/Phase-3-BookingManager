using System;
namespace BookingManagerLibrary.Models
{
    public sealed class BillingProfile
    {
        public int creditCardId { get; set; }
        public string creditCardToken { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public Address BillingAddress { get; set; }
    }
}

