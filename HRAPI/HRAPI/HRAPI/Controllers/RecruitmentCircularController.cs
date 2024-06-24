using HR.ApplicationLayer.Dtos.Recruitment;
using HR.ApplicationLayer.IServices;
using HR.ApplicationLayer.Services;
using HR.Domain.Models.Recruitment;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RecruitmentCircularController : Controller
    {
        private readonly IRecruitmentCircularService _service;
        public RecruitmentCircularController(IRecruitmentCircularService recruitmentCircularService)
        {
            _service = recruitmentCircularService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var designationList = await _service.GetAllAsync();
            return Ok(designationList);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<RecruitmentCircularRequest>> GetById(int id)
        {
            var designation = await _service.GetByIdAsync(id);
            if (designation == null)
            {
                return NotFound();
            }
            return Ok(designation);
        }
        [HttpPost]
        public async Task<ActionResult<RecruitmentCircularRequest>> Add([FromBody] RecruitmentCircularRequest recruitmentCircular)
        {
            if (recruitmentCircular == null)
            {
                return BadRequest("Recruitment Circular is null.");
            }

            var createdRecruitmentCircular = await _service.CreateAsync(recruitmentCircular);
            return CreatedAtAction(nameof(GetById), new { id = createdRecruitmentCircular.RecruitmentCircularId }, createdRecruitmentCircular);
        }

    
     

        [HttpPost("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] RecruitmentCircularRequest recruitmentCircular)
        {
            if (recruitmentCircular == null || id != recruitmentCircular.RecruitmentCircularId)
            {
                return BadRequest();
            }

            var result = await _service.UpDateAsync(id, recruitmentCircular);
            if (result == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await _service.DeleteAsync(Id));
        }
    }
}
