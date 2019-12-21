using Student.Service.interfaces;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace Student.API.API
{
    public class ClassesController : ApiController
    {
        IClassService _classService;
        public ClassesController(IClassService classService)
        {
            _classService = classService; 
        }
        // GET: api/Classes
        public IHttpActionResult Get()
        {
            var classService = _classService.GetAll().AsEnumerable();
            return Ok(classService);
        }

        // GET: api/Classes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Classes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Classes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Classes/5
        public void Delete(int id)
        {
        }
    }
}
