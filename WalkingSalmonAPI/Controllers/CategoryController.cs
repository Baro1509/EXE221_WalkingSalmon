using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace WalkingSalmonAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class CategoryController : ControllerBase {
        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository) {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_categoryRepository.GetAllCategories());
        }
    }
}
