using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Implementation;
using Repository.Models;
using Repository.Models.DTO;
using System.Net.Mime;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WalkingSalmonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IEmployerRepository empRepository = new EmployerRepository();
        private IStudentRepository studentRepository = new StudentRepository();

        //Register Employer
        [HttpPost("EmployerRegister")]
        public async Task<ActionResult<Employer>> EmployerRegister(Employer employer)
        {
            empRepository.CreateEmployer(employer);
            return NoContent();
        }
        //Register Student
        [HttpPost("StudentRegister")]
        public async Task<ActionResult<Employer>> StudentRegister(Student student)
        {
            studentRepository.CreateStudent(student);
            return NoContent();
        }
        //Login Employer
        [HttpPost("EmployerLogin")]
        [Consumes(MediaTypeNames.Application.Json)]

        public async Task<ActionResult<Employer>> EmployerLogin(Account account)
        {
            Employer employer = empRepository.AuthenticateEmployer(account.Email, account.Pwd);
            if (employer == null)
            {
                return NotFound();
            }
            return Ok(employer);
        }
        //Login Student
        [HttpPost("StudentLogin")]
        [Consumes(MediaTypeNames.Application.Json)]

        public async Task<ActionResult<Student>> StudentLogin(Account account)
        {
            Student student = studentRepository.AuthenticateStudent(account.Email, account.Pwd);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
