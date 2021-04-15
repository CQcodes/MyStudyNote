using System;

namespace CSharp.DesignPattern.FactoryPattern.Products
{
    public class Bike : IVehicle
    {
        int _speed;
        int _distance;
        public Bike(int s, int d)
        {
            _speed = s;
            _distance = d;
        }
        public void Drive()
        {
            Console.WriteLine($"Bike is running at speed {_speed}km/h . It will travel {_distance}km distance.");
        }
    }

    public class Scooty : IVehicle
    {
        int _speed;
        int _distance;
        public Scooty(int s, int d)
        {
            _speed = s;
            _distance = d;
        }
        public void Drive()
        {
            Console.WriteLine($"Scooty is running at speed {_speed}km/h . It will travel {_distance}km distance.");
        }
    }
}
