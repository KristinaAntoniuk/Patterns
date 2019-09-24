using AbstractFactoryDemo.AbstractFactory.AbstractInterface;
using AbstractFactoryDemo.AbstractFactory.AbstractProduct;
using AbstractFactoryDemo.AbstractFactory.ConcreteProduct;

namespace AbstractFactoryDemo.AbstractFactory.ConcreteFactory
{
    public class DellFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
