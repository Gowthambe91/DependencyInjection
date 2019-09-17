using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInjection.Models;
using DependencyInjection.DataLayer;

namespace DependencyInjection.BusinessLogic
{
    public class EmployeeBAL
    {
        private IEmployeeDAL employeeDAL; //Inteface of the dependancy class

        /*Property Injection*/
        public IEmployeeDAL IemployeeDAL
        {
            get
            {
                if (this.employeeDAL == null)
                {
                    throw new Exception("Employee is not initialised");
                }
                else
                    return employeeDAL;
            }

            set
            {
                this.employeeDAL = value;
            }
        }
        //Constructor Injection
        /*public EmployeeBAL(IEmployeeDAL employeeDAL) 
        {
            this.employeeDAL = employeeDAL;
        }*/
        public IList<Employee> GetEmployees()
        {
            return employeeDAL.GetEmployees();
        }

        /*Method Injection*/
        public IList<Employee> GetEmployees(IEmployeeDAL employeeDAL)
        {
            return employeeDAL.GetEmployees();
        }
    }
}