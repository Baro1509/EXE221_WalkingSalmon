using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Models;

namespace WalkingSalmonAPI.Controllers {
    [Route("api/jobs")]
    [ApiController]
    public class JobController : ControllerBase {
        private IJobRepository _jobRepository;

        public JobController(IJobRepository jobRepository) {
            _jobRepository = jobRepository;
        }

        [HttpGet]
        public ActionResult GetAllJobs() {
            return Ok(_jobRepository.GetJobs());
        }
        
        [HttpGet("{id:int}")]
        public ActionResult Get(int id) {
            return Ok(_jobRepository.GetJobById(id));
        }
        
        [HttpGet("/employers/{id:int}")]
        public ActionResult GetJobsByEmployer(int id) {
            return Ok(_jobRepository.GetJobsByEmployer(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Job job) {
            _jobRepository.CreateJob(job);
            return Ok();
        }
        
        [HttpPut]
        public IActionResult Update([FromBody] Job job) {
            _jobRepository.UpdateJob(job);
            return Ok();
        }
        
        [HttpDelete]
        public IActionResult Delete(int id) {
            _jobRepository.DeleteJob(id);
            return NoContent();
        }
    }
}
