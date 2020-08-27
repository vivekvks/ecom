using Ecom.Models.Enums;
using System.Text.Json.Serialization;

namespace Ecom.Models.Response
{
    public class UserGetResponse
    {
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        [JsonIgnore]
        public RoleType RoleId { get; set; } 
    }
}
