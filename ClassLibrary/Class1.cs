using System;

namespace ClassLibrary
{
    public class Car
    {
        public string LicensePlate;
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

    public class MC
    {
        public string LicensePlate;
        public DateTime Date;

        public double Price()
        {
            return 125;
        }

        public string Vehicle()
        {
            return "MC";
        }
    }
}
