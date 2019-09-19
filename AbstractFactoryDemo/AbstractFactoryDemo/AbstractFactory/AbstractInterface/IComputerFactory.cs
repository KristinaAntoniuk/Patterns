using AbstractFactoryDemo.AbstractFactory.AbstractProduct;

namespace AbstractFactoryDemo.AbstractFactory.AbstractInterface
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
