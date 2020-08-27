using Ecom.Utility;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Authentication
{
    public interface IJWTHelper
    {
        string GenerateJWTToken(TokenData tokenData, Jwt jwt);
    }
}
