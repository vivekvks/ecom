using Ecom.Models.Enums;
using Ecom.Utility;
using Microsoft.AspNetCore.Authorization;

namespace Ecom.Authentication
{
    public class Policies
    {
        public static AuthorizationPolicy AdminPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(RoleType.Admin.Description()).Build();
        }
        public static AuthorizationPolicy UserPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(RoleType.User.Description()).Build();
        }
    }
}
