using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Student.API.API
{
    public class GradeController : ApiController
    {
        // GET: api/Grade
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Grade/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Grade
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Grade/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Grade/5
        public void Delete(int id)
        {
        }
    }
}
