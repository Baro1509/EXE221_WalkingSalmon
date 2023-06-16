using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Models;

namespace WalkingSalmonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {
        private IJobApplicationRepository _jobAppRepo;

        public JobApplicationController(IJobApplicationRepository jobAppRepo)
        {
            _jobAppRepo = jobAppRepo;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetJobApp(int id)
        {
            return Ok(_jobAppRepo.GetJob(id));
        }

        [HttpGet]
        public IActionResult GetJobApps()
        {
            return Ok(_jobAppRepo.GetJobs());
        }

        [HttpPost]
        public IActionResult ApplyJob([FromBody] JobApplication job)
        {
            _jobAppRepo.ApplyJob(job);
            return Ok();
        }
    }
}
