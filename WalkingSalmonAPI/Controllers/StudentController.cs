using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Implementation;
using Repository.Models;

namespace WalkingSalmonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class StudentController : ControllerBase
    {
        private IStudentRepository _studenRepo;

        public StudentController(IStudentRepository studenRepo)
        {
            _studenRepo = studenRepo;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetStudent(int id)
        {
            return Ok(_studenRepo.GetStudent(id));
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_studenRepo.GetAllStudent());
        }

        [HttpPut]
        public IActionResult UpdateStudent([FromBody] Student student)
        {
            return Ok(_studenRepo.UpdateStudent(student));
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            _studenRepo.CreateStudent(student);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            _studenRepo.DeleteStudent(id);
            return NoContent();
        }
    }
}
