public interface IBooking 
{
    /// <summary>
    /// Returns a list of bookings owned by the driver with the given driverlicense.
    /// </summary>
    /// <param name="driversLicense">The drivers license number to get a booking.</param>
    /// <returns>Returns a list of bookings.</returns>
    public List<Booking> ShowBookings(string driversLicense);

    /// <summary>
    /// Cancels the booking who owns the bookingId given.
    /// </summary>
    /// <param name="bookingId">The unique Id for a booking</param>
    public void CancelBooking(int bookingId);
    
    /// <summary>
    /// Creates a Booking, also the constructor of Booking
    /// </summary>
    /// <param name="booking">The booking that is to be created</param>
    public Booking CreateBooking(Booking booking);
    
    
    ///<summary>
    ///Contract C01
    ///Operation: MakeNewBooking()
    ///Cross References: Create Booking
    ///Preconditions:
    /// - none
    ///Postconditions:	
    ///- A booking instance b is created
    ///- Attributes of b were initialized
    ///- A list of places is returned
    ///</summary>
    ///<returns>Returns a list of places</returns>
    public List<Place> MakeNewBooking();
    
    public List<Car>
}
