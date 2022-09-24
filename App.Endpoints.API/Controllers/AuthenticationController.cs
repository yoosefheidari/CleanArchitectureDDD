using App.Contracts.Authentication;
using App.Services.Services.Authentication;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace App.Endpoints.API.Controllers
{
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationServiceApp _authenticationService;

        public AuthenticationController(IAuthenticationServiceApp authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(request.Email, request.Password);
            var response = new AuthenticationResponse(
                authResult.id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
                );
            
            return Ok(response);
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
            var response = new AuthenticationResponse(
                authResult.id,
                authResult.FirstName,
                authResult.LastName,
                authResult.Email,
                authResult.Token
                );
            return Ok(response);
        }
    }
}
