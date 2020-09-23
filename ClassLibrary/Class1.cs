using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string LicensePlate;
        public DateTime Date;

        public abstract double Price();
        public abstract string VehicleType();

        public void SetLicensePlate(string plateNumber)
        {
            if (plateNumber.Length <= 7)
            {
                LicensePlate = plateNumber;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
    public class Car : Vehicle
    {
        /// <summary>
        /// Method to get the price
        /// </summary>
        /// <returns> double == 240</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Method to get vehicle type
        /// </summary>
        /// <returns> string == Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }

    public class MC : Vehicle
    {
        public override double Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
