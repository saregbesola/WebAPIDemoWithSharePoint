using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (StaffDemoDBEntities entities = new StaffDemoDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
