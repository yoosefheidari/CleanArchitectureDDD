using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services.Authentication
{
    public interface IAuthenticationServiceApp
    {
        AuthenticationResult Login(string Email, string Password);
        AuthenticationResult Register(string FirstName, string LastName, string Email, string Password);
    }
}
