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
    public class StudentController : ApiController
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<IHttpActionResult> Get()
        {
            var studentList = await Task.Run(() => _studentService.GetAll().AsEnumerable());
            return Ok(studentList);
        }


        // POST: api/Student
        public async Task<IHttpActionResult> Post(StudentObj student)
        {
            try
            {
                var _student = await Task.Run(() => _studentService.Create(student));
                return Ok(_student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Student/5
        public async Task<IHttpActionResult> Put([FromBody]StudentObj student)
        {
            try
            {
                await Task.Run(() => _studentService.Update(student));
                return Ok(student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // DELETE: api/Student/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                var student = await Task.Run(() => _studentService.FindById(id));
                _studentService.Delete(student);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
