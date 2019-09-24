using AbstractFactoryDemo.AbstractFactory.AbstractInterface;

namespace AbstractFactoryDemo.AbstractFactory.ConcreteFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeID == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new AppleLaptopFactory();
                }
                else
                {
                    returnValue = new AppleFactory();
                }
            }
            else if (e.EmployeeTypeID == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                    returnValue = new DellFactory();
            }
            return returnValue;
        }
    }

}
