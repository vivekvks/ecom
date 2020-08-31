using Ecom.Utility;

namespace Ecom.Authentication
{
    public interface IJwtHelper
    {
        string GenerateJWTToken(JwtTokenModel tokenData, Jwt jwt);
    }
}
