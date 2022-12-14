using System;
namespace BookingManagerLibrary.Models
{
    public class Expense
    {
        public int ReservationId { get; set; }
        public ExpenseType Type { get; set; }
        public decimal Amount { get; set; }
        public Customer PaidByCustomer { get; set; }

        public bool IsTax => Type == ExpenseType.LocalTax
                          || Type == ExpenseType.StateTax;

        public bool IsDiscount => Type == ExpenseType.Coupon
                               || Type == ExpenseType.EmployeeDiscount
                               || Type == ExpenseType.Promotion;
    }
}

