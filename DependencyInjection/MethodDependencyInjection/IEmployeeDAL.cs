using System.Collections.Generic;

namespace MethodDependencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
