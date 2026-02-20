using HW1_SCD.Models;
using HW1_SCD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW1_SCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentController(StudentService service) 
        {
            _service=service;
        }

        [HttpGet("StudentsList")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_service.GetStudents());
                //200 return kiya 
            }
            catch
            {
                return StatusCode(500, "Internal Server Error");
            }
            
        }

        
        [HttpGet("GettingById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var student = _service.GetById(id);

                if (student == null)
                    return NotFound("Student not found"); 
                // 404 return kiay

                return Ok(student); 
                // 200 return kiaya
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        
        [HttpPost("CreatingStudent")]
        public IActionResult Create(Student student)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState); // 400

                var created = _service.Create(student);

                return CreatedAtAction(nameof(GetById),
                    new { id = created.StudentId }, created); // 201
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("UpdatingStudent/{id}")]
        public IActionResult Update(int id, Student student)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState); // 400

                var updated = _service.Update(id, student);

                if (!updated)
                    return NotFound("Student not found"); // 404

                return NoContent(); // 204
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var deleted = _service.Delete(id);

                if (!deleted)
                    return NotFound("Student not found"); // 404

                return NoContent(); // 204
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}

