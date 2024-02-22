using Mango.Services.AuthAPI.Models.Dto;
using Mango.Services.AuthAPI.Services.Iservices;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {
        private readonly IAuthServices _authServices;
        private ResponseDto _response;

        public AuthAPIController(IAuthServices authServices)
        {
            _authServices = authServices;
            _response = new();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequestDto registrationRequestDto)
        {
            var errorMessage = await _authServices.Register(registrationRequestDto);
            if (errorMessage != null)
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(errorMessage);
            }
            return Ok(_response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> login([FromBody] LoginRequestDto loginRequestDto)
        {
            var loginResponse = await _authServices.Login(loginRequestDto);
            if (loginResponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Username or Password is incorrect";
                return BadRequest(loginResponse);
            }
            _response.Result = loginResponse;
            return Ok(_response);
        }
    }
}
