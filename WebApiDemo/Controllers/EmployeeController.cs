using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessNew;

namespace WebApiDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        Employee empobj = new Employee();
        [HttpGet]
        public IEnumerable<EmployeeClass> FetchAllEmployee()
        {
            return empobj.BindGrid().ToList();
        }

        [HttpGet]
        public EmployeeClass FetchEmployeeByID(int id)
        {
            List<EmployeeClass> myobj = new List<EmployeeClass>();
            myobj = empobj.BindGrid().ToList();
            return myobj.FirstOrDefault(e => e.ID == id);
        }
        
    }
}
