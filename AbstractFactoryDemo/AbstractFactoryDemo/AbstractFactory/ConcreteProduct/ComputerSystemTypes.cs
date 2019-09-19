

using AbstractFactoryDemo.AbstractFactory.AbstractProduct;
using AbstractFactoryDemo.Enums;

namespace AbstractFactoryDemo.AbstractFactory.ConcreteProduct
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}
