using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faraday_Contract
{
    public class Booking
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

        /// Empty constructor
        public Booking()
        {

        }

        public Booking(int bookingId, int carId, int customerId, string pickupLocation, DateTime pickupTime)
        {
            this.BookingId = bookingId;
            this.CarId = carId;
            this.CustomerId = customerId;
            this.PickupLocation = pickupLocation;
            this.pickupTime = pickupTime;
        }

        ///Getters and setters
        public int BookingId { get => bookingId; set => bookingId = value; }
        public int CarId { get => carId; set => carId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string PickupLocation { get => pickupLocation; set => pickupLocation = value; }
        public DateTime PickupTime { get => pickupTime; set => pickupTime = value; }

    }

}
