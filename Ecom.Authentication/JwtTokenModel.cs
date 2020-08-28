using Ecom.Models.Enums;

namespace Ecom.Authentication
{
    public class JwtTokenModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public RoleType RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRegistrationCompleted { get; set; }
    }
}
