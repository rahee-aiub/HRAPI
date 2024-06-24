using HR.API.Models;
using HR.ApplicationLayer.IServices;
using HR.ApplicationLayer.Services;
using HR.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RegisterController : ControllerBase
    {
       
        private readonly ILoginUserService _loginUserService;
        private readonly ICommonService _CommonService;
        public RegisterController( LoginUserService loginUser,CommonService commonService)
        {
            _loginUserService = loginUser;
            _CommonService = commonService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] UserModel login)
        {

            if (login == null)
            {
                return BadRequest("User model cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(login.Username) || string.IsNullOrWhiteSpace(login.Password))
            {
                return BadRequest("Username and password cannot be empty.");
            }

            var (hashedPassword, salt) = _CommonService.HashPassword(login.Password);

            var user = new LoginUser
            {
                Username = login.Username,
                PasswordHash = hashedPassword,
                PasswordSalt = salt,
                CREATE_BY = "admin",
                CREATE_DATE = DateTime.Now
            };

            var data = await _loginUserService.CreateAsync(user);

            if (data == null)
            {
                return StatusCode(500, "An error occurred while creating the user.");
            }

            return Ok(data);
        }


    }



}

