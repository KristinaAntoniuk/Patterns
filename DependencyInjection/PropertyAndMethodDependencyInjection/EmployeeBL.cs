using System;
using System.Collections.Generic;

namespace PropertyDependencyInjection
{
    public class EmployeeBL
    {
        private IEmployeeDAL employeeDAL;
        public IEmployeeDAL employeeDataObject
        {
            set
            {
                this.employeeDAL = value;
            }
            get
            {
                if (employeeDAL == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return employeeDAL;
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDataObject.SelectAllEmployees();
        }
    }

}
