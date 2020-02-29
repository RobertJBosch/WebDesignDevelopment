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

        // [HttpPost]
        // public ActionResult Post([FromBody] Instructor instructor)
        // {
        //     instructor.FirstName = getNextFirstName();
        //     instructor.MiddleInitial = getNextMiddleInitial();
        //     instructor.LastName = getNextLastName();

        //     InMemory.Instructors.Add(instructor);

        //     return CreatedAtAction(nameof(GetByFirstName), new { firstname = instructor.FirstName, 
        //     middleinitial = instructor.MiddleInitial, lastname = instructor.LastName }, instructor);
        // }

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

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }

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
