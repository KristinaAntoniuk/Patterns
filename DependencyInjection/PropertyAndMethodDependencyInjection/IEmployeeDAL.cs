using System.Collections.Generic;

namespace PropertyDependencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
