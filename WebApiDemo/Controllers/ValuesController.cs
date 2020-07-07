using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        static List<String> obj = new List<string>()
        {
            "Akib","Archana","Mamta","Atik"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return  obj;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return obj[id];
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            obj.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            obj[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            obj.RemoveAt(id);
        }
    }
}
