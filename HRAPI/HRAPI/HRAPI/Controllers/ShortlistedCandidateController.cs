using HR.ApplicationLayer.Dtos.Recruitment;
using HR.ApplicationLayer.IServices;
using HR.ApplicationLayer.Services;
using HR.Domain.Models.Recruitment;
using Microsoft.AspNetCore.Mvc;

namespace HR.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ShortlistedCandidateController : Controller
    {
        private readonly IShortlistedCandidateService _service;
        public ShortlistedCandidateController(IShortlistedCandidateService shortlistedCandidateService)
        {
            _service = shortlistedCandidateService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var candidateList = await _service.GetAllAsync();
            return Ok(candidateList);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ShortlistedCandidateRequest>> GetById(int id)
        {
            var shortlistedCandidate = await _service.GetByIdAsync(id);
            if (shortlistedCandidate == null)
            {
                return NotFound();
            }
            return Ok(shortlistedCandidate);
        }


        [HttpPost]
        public async Task<ActionResult<ShortlistedCandidateRequest>> Add([FromBody] ShortlistedCandidateRequest shortlistedCandidateRequest)
        {
            if (shortlistedCandidateRequest == null)
            {
                return BadRequest("Shortlised Candidate is null.");
            }

            var created = await _service.CreateAsync(shortlistedCandidateRequest);
            return CreatedAtAction(nameof(GetById), new { id = created.ApplicationId }, created);
        }

    
        [HttpPost("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ShortlistedCandidateRequest shortlistedCandidateRequest)
        {
            if (shortlistedCandidateRequest == null || id != shortlistedCandidateRequest.CandidateId)
            {
                return BadRequest();
            }

            var result = await _service.UpDateAsync(id, shortlistedCandidateRequest);
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
