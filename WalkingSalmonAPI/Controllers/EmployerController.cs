using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Models;

namespace WalkingSalmonAPI.Controllers {
    [Route("api/employers")]
    [ApiController]
    [EnableCors]
    public class EmployerController : ControllerBase {
        private IEmployerRepository _employerRepository;

        public EmployerController(IEmployerRepository employerRepository) {
            _employerRepository = employerRepository;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetEmployer(int id) {
            return Ok(_employerRepository.GetEmployer(id));
        }

        [HttpGet]
        public IActionResult GetEmployers() {
            return Ok(_employerRepository.GetEmployers());
        }

        [HttpPut]
        public IActionResult UpdateEmployer([FromBody] Employer employer) {
            return Ok(_employerRepository.UpdateEmployer(employer));
        }

        [HttpPost]
        public IActionResult CreateEmployer([FromBody] Employer employer) {
            _employerRepository.CreateEmployer(employer);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteEmployer(int id) {
            _employerRepository.DeleteEmployer(id);
            return NoContent();
        }
    }
}
