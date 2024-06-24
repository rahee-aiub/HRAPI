using HR.ApplicationLayer.IServices;
using HR.ApplicationLayer.Services;
using HR.Domain.Models.Setup;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DesignationController : ControllerBase
    {
        private readonly IDesignationService _designationService;
        public DesignationController(IDesignationService designationService)
        {
            _designationService = designationService;
        }

        [HttpGet]
        public async Task<IActionResult> DesignationList()
        {
            var designationList = await _designationService.GetAllAsync();
            return Ok(designationList);
        }

        [HttpPost]
        public async Task<ActionResult<Designation>> AddDesignation([FromBody] Designation designation)
        {
            if (designation == null)
            {
                return BadRequest("Designation is null.");
            }

            var createdDesignation = await _designationService.CreateAsync(designation);
            return CreatedAtAction(nameof(GetDesignationById), new { id = createdDesignation.DesignationId }, createdDesignation);
        }

    
        [HttpGet("{id}")]
        public async Task<ActionResult<Designation>> GetDesignationById(int id)
        {
            var designation = await _designationService.GetByIdAsync(id);
            if (designation == null)
            {
                return NotFound();
            }
            return Ok(designation);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDesignation(int id, [FromBody] Designation designation)
        {
            if (designation == null || id != designation.DesignationId)
            {
                return BadRequest();
            }

            var result = await _designationService.UpDateAsync(id, designation);
            if (result == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
