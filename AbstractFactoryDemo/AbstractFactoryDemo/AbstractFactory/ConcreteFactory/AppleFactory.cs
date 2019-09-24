using AbstractFactoryDemo.AbstractFactory.AbstractInterface;
using AbstractFactoryDemo.AbstractFactory.AbstractProduct;
using AbstractFactoryDemo.AbstractFactory.ConcreteProduct;

namespace AbstractFactoryDemo.AbstractFactory.ConcreteFactory
{
    // implementing the abstract factory interface IComputerFactory
    // to create concrete product for APPLE Laptop and Desktop
    public class AppleFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new APPLE();
        }
        public IProcessor Processor()
        {
            return new I7();
        }
        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    // AS for Laptop and Desktop the Brand and Peocessor Remains the same
    // So, lets implement the MACFactory to create the MACLaptopFactory product
    // and here we need to override the SystemType function
    public class AppleLaptopFactory : AppleFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
