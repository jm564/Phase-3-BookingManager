using System;
using System.Net;

namespace BookingManagerLibrary.Models
{
    public class Result
    {
        public bool IsSuccessful { get; set; }
        public string? ErrorMessage { get; set; }
        public HttpStatusCode ErrorId { get; set; }
    }

    public sealed class DataResult<T> : Result
    {
        public T? Data { get; set; }
    }
}

