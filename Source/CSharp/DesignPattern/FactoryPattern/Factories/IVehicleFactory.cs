using CSharp.DesignPattern.FactoryPattern.Products;

namespace CSharp.DesignPattern.FactoryPattern.Factories
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}
