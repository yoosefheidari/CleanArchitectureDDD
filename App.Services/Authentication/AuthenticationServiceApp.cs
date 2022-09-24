using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Authentication
{
    public class AuthenticationServiceApp : IAuthenticationServiceApp
    {
        public AuthenticationResult Login(string Email, string Password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                "firstName",
                "lastName",
                Email,
                "token"
                );
        }

        public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                FirstName,
                LastName,
                Email,
                "token"
                );
        }
    }
}
