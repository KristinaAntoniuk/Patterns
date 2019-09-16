using System.Collections.Generic;

namespace ConstructorDependencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
