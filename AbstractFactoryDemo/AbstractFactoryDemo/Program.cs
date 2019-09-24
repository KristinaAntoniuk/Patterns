using AbstractFactoryDemo.AbstractFactory.AbstractInterface;
using AbstractFactoryDemo.AbstractFactory.Client;
using AbstractFactoryDemo.AbstractFactory.ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the Employee Object
            Employee employee = new Employee()
            {
                Name = "Pranaya",
                JobDescription = "Manager",
                Department = "HR",
                EmployeeTypeID = 1
            };

            // Create the abstract factory object
            IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
            // use the abstract factory object while creating the client and 
            // then get the system details
            EmployeeSystemManager manager = new EmployeeSystemManager(factory);
            employee.ComputerDetails = manager.GetSystemDetails();
            // Store the Employee into the database
            using (DesignPatternDBEntities dBEntities = new DesignPatternDBEntities())
            {
                dBEntities.Employees.Add(employee);
                dBEntities.SaveChanges();
            }
            Console.WriteLine("Employee data inserted");
            Console.ReadKey();
        }
    }
}
