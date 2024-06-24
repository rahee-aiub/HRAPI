using HR.ApplicationLayer.Dtos;
using HR.ApplicationLayer.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService categoryService)
        {
            _service = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var categorylist = await _service.GetAllAsync();
            return Ok(categorylist);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryRequest>> GetById(int id)
        {
            var designation = await _service.GetByIdAsync(id);
            if (designation == null)
            {
                return NotFound();
            }
            return Ok(designation);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryRequest model)
        {
            return Ok(await _service.CreateAsync(model));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await _service.DeleteAsync(Id));
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryRequest model)
        {
            return Ok(await _service.UpDateAsync(model.CategoryId, model));
        }
    }
}
