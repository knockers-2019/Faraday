public interface IBooking 
{
    /// <summary>
    /// Returns a list of bookings owned by the driver with the given driverlicense.
    /// </summary>
    /// <param name="driversLicense">The drivers license number to get a booking.</param>
    /// <returns>Returns a list of bookings.</returns>
    public List<Booking> ShowBookings(string driversLicense) {}

    /// <summary>
    /// Cancels the booking who owns the bookingId given.
    /// </summary>
    /// <param name="bookingId">The unique Id for a booking</param>
    public void CancelBooking(int bookingId) {}
    
    /// <summary>
    /// Creates a Booking, also the constructor of Booking
    /// </summary>
    /// <param name="bookingId">The Id of the booking, makes the booking unique.</param>
    /// <param name="carId">The id of the car to associate a booking with a car.</param>
    /// <param name="customerId">The id of the custumer to associate a booking with a customer.</param>
    /// <param name="pickUpLocation">The pickup location.</param>
    /// <param name="pickupTime">The pickup location.</param>
    public void Booking CreateBooking(int bookingId, int carId, int customerId, string pickUpLocation, DateTime pickupTime) {}
}
