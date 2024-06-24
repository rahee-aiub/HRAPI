using HR.ApplicationLayer.Dtos.Recruitment;
using HR.ApplicationLayer.IServices;
using HR.ApplicationLayer.Services;
using HR.Domain.Models.Recruitment;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CandidateApplicationController : Controller
    {
        private readonly ICandidateApplicationService _service;
        public CandidateApplicationController(ICandidateApplicationService CandidateApplicationService)
        {
            _service = CandidateApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var designationList = await _service.GetAllAsync();
            return Ok(designationList);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<CandidateApplicationRequest>> GetById(int id)
        {
            var designation = await _service.GetByIdAsync(id);
            if (designation == null)
            {
                return NotFound();
            }
            return Ok(designation);
        }


        [HttpPost]
        public async Task<ActionResult<CandidateApplicationRequest>> Add([FromBody] CandidateApplicationRequest candidateApplication)
        {
            if (candidateApplication == null)
            {
                return BadRequest("Candidate Application is null.");
            }

            var createdCandidateApplication = await _service.CreateAsync(candidateApplication);
            return CreatedAtAction(nameof(GetById), new { id = createdCandidateApplication.ApplicationId }, createdCandidateApplication);
        }

    
        [HttpPost("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] CandidateApplicationRequest candidateApplicationRequest)
        {
            if (candidateApplicationRequest == null || id != candidateApplicationRequest.ApplicationId)
            {
                return BadRequest();
            }

            var result = await _service.UpDateAsync(id, candidateApplicationRequest);
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
