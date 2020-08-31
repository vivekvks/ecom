using Ecom.Models.Enums;

namespace Ecom.Authentication
{
    public interface IJwtReader
    {
        int UserId { get; }
        string Email { get; }
        string PhoneNo { get; }
        RoleType RoleId { get; }
        bool IsRegistrationCompleted { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
