using App.Services.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services.Authentication
{
    public class AuthenticationServiceApp : IAuthenticationServiceApp
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationServiceApp(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Login(string Email, string Password)
        {
            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, "Yousef", "Heidari");
            return new AuthenticationResult(
                Guid.NewGuid(),
                "firstName",
                "lastName",
                Email,
                token
                );
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, FirstName, LastName);
            return new AuthenticationResult(
                Guid.NewGuid(),
                FirstName,
                LastName,
                Email,
                token
                );
        }
    }
}
