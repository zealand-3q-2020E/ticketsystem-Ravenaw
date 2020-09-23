using System;

namespace ClassLibrary
{
    public class Car
    {
        public string LicencePlate;
        public DateTime Date;

        /// <summary>
        /// Method to get the price
        /// </summary>
        /// <returns> double == 240</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Method to get vehicle type
        /// </summary>
        /// <returns> string == Car</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
