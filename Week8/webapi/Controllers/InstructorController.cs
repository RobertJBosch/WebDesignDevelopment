using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstructorController : ControllerBase
    {
        private readonly ILogger<InstructorController> _logger;

        public InstructorController(ILogger<InstructorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Instructor>> Get()
        {
            return Ok(getInstructors());
        }

        [HttpGet("{firstname}")]
        public ActionResult<string> GetByFirstName(string firstname)
        {
            if (firstname == "")
            {
                return BadRequest();
            }
            
            var instructor = InMemory.Instructors.FirstOrDefault(i => i.FirstName == firstname);

            if (instructor == null)
            {
                return NotFound();
            }

            return Ok(instructor);
        }

        private List<Instructor> getInstructors()
        {
            return InMemory.Instructors;
            
        }  

        private int getNext()
        {
            return InMemory.Instructors.Max(p => Int32.Parse(p.FirstName)) + 1;
        }
    }
}
