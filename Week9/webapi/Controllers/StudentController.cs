using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        public ActionResult<List<StudentViewModel>> GetAllStudents()
        {
            var result = _studentServices.GetAllStudents();
            return Ok(result);
        }
    }
}