
using AbstractFactoryDemo.AbstractFactory.AbstractProduct;
using AbstractFactoryDemo.Enums;

namespace AbstractFactoryDemo.AbstractFactory.ConcreteProduct
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString();
        }
    }
}
