using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository;
using Microsoft.AspNetCore.Cors;

namespace WalkingSalmonAPI.Controllers {
    [Route("api/transactions")]
    [ApiController]
    [EnableCors]
    public class TransactionController : ControllerBase {
        private ITransactionDetailRepository _repository;

        public TransactionController(ITransactionDetailRepository repository) {
            _repository = repository;
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id) {
            return Ok(_repository.GetTransaction(id));
        }
        
        [HttpGet]
        public IActionResult Get() {
            return Ok(_repository.GetAllTransaction());
        }

        [HttpGet("/jobs/{id:int}")]
        public IActionResult GetByJobId(int id) {
            return Ok(_repository.GetTransactionDetailsByJobId(id));
        }

        [HttpPut]
        public IActionResult Update([FromBody] TransactionDetail trans) {
            return Ok(_repository.UpdateTransactionDetail(trans));
        }

        [HttpPost]
        public IActionResult Create([FromBody] TransactionDetail trans) {
            _repository.CreateTransactionDetail(trans);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            _repository.DeleteTransactionDetail(id);
            return NoContent();
        }
    }
}
