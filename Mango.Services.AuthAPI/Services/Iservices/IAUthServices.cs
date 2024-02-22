using Mango.Services.AuthAPI.Models.Dto;

namespace Mango.Services.AuthAPI.Services.Iservices
{
    public interface IAuthServices
    {
        Task<string> Register(RegistrationRequestDto registrationRequestDto);
        Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto);
    }
}
