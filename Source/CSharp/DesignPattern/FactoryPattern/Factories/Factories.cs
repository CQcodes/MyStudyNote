using CSharp.DesignPattern.FactoryPattern.Products;

namespace CSharp.DesignPattern.FactoryPattern.Factories
{
    public class BikeFactory : IVehicleFactory
    {
        int _speed;
        int _distance;
        public BikeFactory(int s, int d)
        {
            _speed = s;
            _distance = d;
        }
        public IVehicle CreateVehicle()
        {
            return new Bike(_speed, _distance);
        }
    }

    public class ScootyFactory : IVehicleFactory
    {
        int _speed;
        int _distance;
        public ScootyFactory(int s, int d)
        {
            _speed = s;
            _distance = d;
        }
        public IVehicle CreateVehicle()
        {
            return new Scooty(_speed, _distance);
        }
    }
}
