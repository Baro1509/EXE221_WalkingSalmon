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
        private IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();

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
        //Login Admin
        [HttpPost("AdminLogin")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<Employer>> AdminLogin(Account account)
        {
            Employer employer = empRepository.AuthenticateEmployer(account.Email, account.Pwd);
            if (employer == null)
            {
                if (account.Email.Equals(configuration["Admin:Email"], StringComparison.OrdinalIgnoreCase) &&
                    account.Pwd.Equals(configuration["Admin:Password"]))
                {
                    return new Employer { Email = configuration["Admin:Email"], Pwd = configuration["Admin:Password"] };
                }
                return NotFound();
            }
            return Ok(employer);
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
