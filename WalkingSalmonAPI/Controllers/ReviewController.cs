using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Implementation;
using Repository.Models;

namespace WalkingSalmonAPI.Controllers {
    [Route("api/reviews")]
    [ApiController]
    [EnableCors]
    public class ReviewController : ControllerBase {
        private IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository) {
            _reviewRepository = reviewRepository;
        }

        [HttpGet]
        public ActionResult GetAllJobs() {
            return Ok(_reviewRepository.GetReviews());
        }

        [HttpGet("{id:int}")]
        public ActionResult Get(int id) {
            return Ok(_reviewRepository.GetReviewById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] Review review) {
            _reviewRepository.CreateReview(review);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Review review) {
            _reviewRepository.UpdateReview(review);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            _reviewRepository.DeleteReview(id);
            return NoContent();
        }
    }
}
