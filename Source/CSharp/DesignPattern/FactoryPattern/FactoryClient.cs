using CSharp.DesignPattern.FactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.DesignPattern.FactoryPattern
{
    public class FactoryPatternDemo
    {
        public void Execute()
        {
            IVehicleFactory vehicleFactory = null;

            Console.WriteLine("Enter 1 to drive Bike.");
            Console.WriteLine("Enter 2 to drive Scooty.");
            var choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                vehicleFactory = new BikeFactory(110, 55);
            else
                vehicleFactory = new ScootyFactory(80, 65);

            var vehicle = vehicleFactory.CreateVehicle();
            vehicle.Drive();
        }
    }
}
