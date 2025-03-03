using System;

namespace CSharp1
{
    interface IVehicle
    {
        void Drive();
    }
    class car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }
    class bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a bike.");
        }
    }
    class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            if (vehicleType.ToLower() == "car")
                return new car();
            else if (vehicleType.ToLower() == "bike")
                return new bike();
            else
                throw new ArgumentException("Invalid vehicle type");
        }
    }
}