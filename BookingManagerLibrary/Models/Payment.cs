using System;
namespace BookingManagerLibrary.Models
{
    public sealed class Payment
    {
        public int PaymentId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public BillingProfile PaymentMethod { get; set; }
    }
}

