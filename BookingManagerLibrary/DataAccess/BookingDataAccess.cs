using System;
using System.Data;
using System.Data.SqlClient;
using BookingManagerLibrary.Models;

namespace BookingManagerLibrary.DataAccess
{
    public class BookingDataAccess
    {
        private readonly string bookingDBConnection;

        public BookingDataAccess()
        {
            this.bookingDBConnection = "";
        }

        #region Create
        public DataResult<Employee> CreateUser(Employee employee)
        {
            try
            {
                using(var connection = new SqlConnection(bookingDBConnection))
                using(var command = new SqlCommand("", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    int result = command.ExecuteNonQuery();

                    return result > 0
                                    ? new DataResult<Employee> { IsSuccessful = true, Data = employee }
                                    : new DataResult<Employee> { IsSuccessful = false, ErrorMessage = "Failed to Create User" };
                            
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new DataResult<Employee> { IsSuccessful = false, ErrorMessage = $"Failed to Create User {ex.Message}" };
            }
        }

        public DataResult<Trip> CreateTrip(Trip trip)
        {
            try
            {
                using (var connection = new SqlConnection(bookingDBConnection))
                using (var command = new SqlCommand("", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    int result = command.ExecuteNonQuery();

                    return result > 0
                                    ? new DataResult<Trip> { IsSuccessful = true, Data = trip }
                                    : new DataResult<Trip> { IsSuccessful = false, ErrorMessage = "Failed to Create Trip" };

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new DataResult<Trip> { IsSuccessful = false, ErrorMessage = $"Failed to Create Trip {ex.Message}" };
            }
        }

        public DataResult<Reservation> CreateReservation()
        {
            return null;
        }

        public DataResult<BillingProfile> CreateBillingProfile()
        {
            return null;
        }
        #endregion

        #region Read
        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}

