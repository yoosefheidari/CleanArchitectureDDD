using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services.Authentication
{
    public record AuthenticationResult(
         Guid id,
         string FirstName,
         string LastName,
         string Email,
         string Token
         );
}
