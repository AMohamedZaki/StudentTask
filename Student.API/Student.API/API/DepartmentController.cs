using Student.Model;
using Student.Service.interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Student.API.API
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DepartmentController : ApiController
    {
        private IDepartmentsService _departmentsService;
        public DepartmentController(IDepartmentsService departmentsService)
        {
            _departmentsService = departmentsService;
        }

        // GET: api/Department
        public async Task<IHttpActionResult> Get()
        {
            var departmentList = await Task.Run(() =>_departmentsService.GetAll().AsEnumerable());
            return Ok(departmentList);
        }

  
        // POST: api/Department
        public async Task<IHttpActionResult> Post(Department department)
        {
            try
            {
                var _department = await Task.Run(() => _departmentsService.Create(department));
                return Ok(_department);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Department/
        public async Task<IHttpActionResult> Put([FromBody]Department department)
        {
            try
            {
                await Task.Run(() => _departmentsService.Update(department));
                return Ok(department);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Department/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                var department = await Task.Run(() => _departmentsService.FindById(id));
                _departmentsService.Delete(department);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
