using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInjection.BusinessLogic;
using DependencyInjection.Models;

namespace DependencyInjection.DataLayer
{
    public interface IEmployeeDAL
    {
        IList<Employee> GetEmployees();
    }

    public class EmployeeDAL : IEmployeeDAL
    {

        public IList<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>() {
               new Employee { EmployeeId = 1, Name = "Gowthaman", Department = "IT"},
               new Employee { EmployeeId = 2, Name = "Arun", Department = "Security"},
               new Employee { EmployeeId = 3, Name = "Raj", Department = "Automation"}
           };

            return employees;
        }
    }
}