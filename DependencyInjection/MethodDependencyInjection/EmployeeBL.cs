using System.Collections.Generic;

namespace MethodDependencyInjection
{
    public class EmployeeBL
    {
        private IEmployeeDAL employeeDAL;

        public List<Employee> GetAllEmployees(IEmployeeDAL _employeeDAL)
        {
            employeeDAL = _employeeDAL;
            return employeeDAL.SelectAllEmployees();
        }
    }

}
