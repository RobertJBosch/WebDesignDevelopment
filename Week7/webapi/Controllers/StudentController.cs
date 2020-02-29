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
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Students>> GetAllStudents()
        {
            var result = _dbContext.Students.ToList();
            return Ok(result);
        }

        // [HttpGet("{student_id}")]
        // public ActionResult<Students> GetProduct(int studentId)
        // {
        //     var student = _dbContext.Student
        //         .SingleOrDefault(p => p.StudenttId == studentId);

        //     if (student != null) {
        //         return student;
        //     } else {
        //         return NotFound();
        //     }
        // }

        // [HttpPost]
        // public ActionResult<Product> AddProduct(Product product)
        // {
        //     _dbContext.Product.Add(product);
        //     _dbContext.SaveChanges();

        //     // return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);

        //     return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        // }

        // [HttpDelete("{productId}")]
        // public ActionResult DeleteProduct(int productId)
        // {
        //     var product = new Product { ProductId = productId };

        //     _dbContext.Product.Attach(product);
        //     _dbContext.Product.Remove(product);
        //     _dbContext.SaveChanges();

        //     return Ok();
        // }

        // [HttpPut("{productId}")]
        // public ActionResult UpdateProduct(int productId, Product productUpdate)
        // {
        //     var product = _dbContext.Product
        //         .SingleOrDefault(p => p.ProductId == productId);

        //     if (product != null)
        //     {
        //         product.Name = productUpdate.Name;
        //         product.Price = productUpdate.Price;
        //         product.Count = productUpdate.Count;

        //         _dbContext.Update(product);

        //         _dbContext.SaveChanges();
        //     }

        //     return NoContent();
        // }
    }
}