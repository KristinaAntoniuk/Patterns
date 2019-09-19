

namespace AbstractFactoryDemo.Enums
{
    // As we are going to use Laptop and Desktop computer types, 
    // so create an enum which contains these two computer types
    public enum ComputerTypes
    {
        Laptop,
        Desktop
    }
    // As we know the brands for the Laptop and Desktop will be APPLE and DELL,  
    // so create another enum which contains the APPLE and DELL Brands
    public enum Brands
    {
        APPLE,
        DELL
    }
    // Finally, let's create another enum which will contains the processors 
    // such as I3, I5 and I7
    public enum Processors
    {
        I3,
        I5,
        I7
    }
}
