using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.Models;
using DependencyInjection.BusinessLogic;
using DependencyInjection.DataLayer;

namespace DependencyInjection.Controllers
{
    public class EmployeeController : Controller
    {
        /*https://dotnettutorials.net/lesson/dependency-injection-design-pattern-csharp/*/
        // GET: Employee
        public ActionResult Index()
        {

            /*EmployeeBAL employeeBAL = new EmployeeBAL(); /* Now Employee BAL directly creates an object of Employee DAL
            Makes, Employee DAL a dependancy of EmployeeBAL class , tightly bound class object creation makes not independently testable*/
            /* EmployeeBAL employeeBAL = new EmployeeBAL(new EmployeeDAL()); /* Now passing the EmployeeDAL object, but at receiver end, receive it as 
             interface of the dependancy class, so that when unit testing we can create a dummy class with that same interface and sample method implementation, 
             can test the class successfuly independently --> This is called as Construction Injection*/

            EmployeeBAL employeeBAL = new EmployeeBAL();
            employeeBAL.IemployeeDAL = new EmployeeDAL();//Property Injection - can be used when injection can happen as late as possible, not like constructor injection.
            //IList<Employee> employees = employeeBAL.GetEmployees();
            IList<Employee> employees = employeeBAL.GetEmployees(new EmployeeDAL());//Method injection - can be used if only one method has dependancy involved, but not other methods
            return View(employees);
        }
    }
}