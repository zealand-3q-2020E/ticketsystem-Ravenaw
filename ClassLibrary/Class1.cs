using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string LicensePlate;
        public DateTime Date;
        public bool BridgeDiscount=false;

        public abstract double Price();
        public abstract string VehicleType();

        /// <summary>
        /// Sets license plate
        /// </summary>
        /// <param name="plateNumber"></param>
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

        /// <summary>
        /// Enables discount
        /// </summary>
        public void EnableDiscount()
        {
            BridgeDiscount = true;
        }
    }
    public class Car : Vehicle
    {
        /// <summary>
        /// Method to get the price
        /// </summary>
        /// <returns>240 or -5%</returns>
        public override double Price()
        {
            return BridgeDiscount ? 240.0*0.95 : 240.0;
        }

        /// <summary>
        /// Method to get vehicle type
        /// </summary>
        /// <returns>Car</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }

    public class MC : Vehicle
    {
        /// <summary>
        /// Method to get the price
        /// </summary>
        /// <returns>125 or -5%</returns>
        public override double Price()
        {
            return BridgeDiscount ? 125.0 * 0.95 : 125.0;
        }

        /// <summary>
        /// Method to get vehicle type
        /// </summary>
        /// <returns>MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
