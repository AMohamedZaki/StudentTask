using Student.Model;
using Student.Service.interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Student.API.API
{
    public class DepartmentController : ApiController
    {
        // GET: api/Department
        private IDepartmentsService _departmentsService;
        public DepartmentController(IDepartmentsService departmentsService)
        {
            _departmentsService = departmentsService;
        }
        public List<Department> Get()
        {
            return _departmentsService.GetAll().ToList();
        }

        // GET: api/Department/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Department
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Department/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
        }
    }
}
