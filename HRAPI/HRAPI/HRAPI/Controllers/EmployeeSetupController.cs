using HR.ApplicationLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HR.ApplicationLayer.IServices;
using AutoMapper;
using HR.ApplicationLayer.Dtos.Setup;

namespace HR.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EmployeeSetupController : ControllerBase
    {
        private readonly IEmployeeService _Service;

        public EmployeeSetupController(IEmployeeService Service)
        {
            _Service = Service;

        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var employeeList = await _Service.GetAllAsync();
            return Ok(employeeList);
        }


        [HttpGet("Id")]
        public async Task<IActionResult> GetById(int Id)
        {
            var employee = await _Service.GetByIdAsync(Id);
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] EmployeeRequest employee)
        {
            var employees = await _Service.CreateAsync(employee);
            return Ok(employees);
        }

        [HttpPost("Id")]
        public async Task<IActionResult> Update(int Id, [FromBody] EmployeeRequest employee)
        {
            var employees = await _Service.UpDateAsync(Id,employee);
            return Ok(employees);
        }

        [HttpPost("Id")]
        public async Task<IActionResult> Delete(int Id)
        {
            var employees = await _Service.DeleteAsync(Id);
            return Ok(employees);
        }
    }
}
