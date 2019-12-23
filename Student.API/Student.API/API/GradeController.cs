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
    public class GradeController : ApiController
    {

        private IGradeService _gradeService;
        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }


        // GET: api/Grade
        public async Task<IHttpActionResult> Get()
        {
            var departmentList = await Task.Run(() => _gradeService.GetAll().AsEnumerable());
            return Ok(departmentList);
        }

        // POST: api/Grade
        // POST: api/Department
        public async Task<IHttpActionResult> Post(Grade grade)
        {
            try
            {
                var _grade = await Task.Run(() => _gradeService.Create(grade));
                return Ok(_grade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Grade/5
        public async Task<IHttpActionResult> Put([FromBody]Grade grade)
        {
            try
            {
                await Task.Run(() => _gradeService.Update(grade));
                return Ok(grade);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // DELETE: api/Grade/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                var grade = await Task.Run(() => _gradeService.FindById(id));
                _gradeService.Delete(grade);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
