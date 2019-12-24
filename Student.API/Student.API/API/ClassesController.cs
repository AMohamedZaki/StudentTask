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
    public class ClassesController : ApiController
    {
        IClassService _classService;
        public ClassesController(IClassService classService)
        {
            _classService = classService; 
        }

        // GET: api/Classes
        public async Task<IHttpActionResult> GetAsync()
        {
            var classList = await Task.Run(() => _classService.GetAll().AsEnumerable());
            return Ok(classList);
        }

      
        // POST: api/Classes
        public async Task<IHttpActionResult> Post(Classes @class)
        {
            try
            {
                var _class = await Task.Run(() => _classService.Create(@class));
                return Ok(_class);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Classes/5
        public async Task<IHttpActionResult> Put([FromBody]Classes @class)
        {
            try
            {
                await Task.Run(() => _classService.Update(@class));
                return Ok(@class);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Classes/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                var @class = await Task.Run(() => _classService.FindById(id));
                _classService.Delete(@class);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
