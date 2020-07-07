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
        public IEnumerable<EmployeeClass> Get()
        {
           
            return empobj.BindGrid().ToList();
        }

        public EmployeeClass Get(int myID)
        {
            List<EmployeeClass> myobj = new List<EmployeeClass>();
            return myobj.FirstOrDefault(e => e.ID == myID);
        }
        
    }
}
