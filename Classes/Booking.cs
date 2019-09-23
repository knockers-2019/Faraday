class Booking
{
    /// <summary>
    /// Creates a Booking, also the constructor of Booking
    /// </summary>
    /// <param name="bookingId">The Id of the booking, makes the booking unique.</param>
    /// <param name="carId">The id of the car to associate a booking with a car.</param>
    /// <param name="customerId">The id of the custumer to associate a booking with a customer.</param>
    /// <param name="pickUpLocation">The pickup location.</param>
    /// <param name="pickupTime">The pickup location.</param>
    
    private int bookingId;
    private int carId;
    private int customerId;
    private string pickupLocation;
    private DateTime pickupTime;
    
    public Booking(int bookingId, int carId, int customerId, string pickupLocation, DateTime pickupTime)
    {
        this.bookingId = bookingId;
        this.carId = carId;
        this.customerId = customerId;
        this.pickupLocation = pickupLocation;
        this.puckupTime = pickupTime;
    }
    
    /// Empty constructor
    public Booking(){
    
    }
    
    ///Getters and setters
    public int bookingId {get; set;}
    public int carId {get; set;}
    public int customerId {get; set;}
    public string pickupLocation {get; set;}
    public DateTime pickupTime {get; set;}
}
