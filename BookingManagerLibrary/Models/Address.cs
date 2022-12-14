﻿using System;
namespace BookingManagerLibrary.Models
{
    public sealed class Address
    {
        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}

