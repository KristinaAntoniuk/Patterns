using AbstractFactoryDemo.AbstractFactory.AbstractProduct;
using AbstractFactoryDemo.Enums;

namespace AbstractFactoryDemo.AbstractFactory.ConcreteProduct
{
    public class APPLE : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brands.DELL.ToString();
        }
    }
}
