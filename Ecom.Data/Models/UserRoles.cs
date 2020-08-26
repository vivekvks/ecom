namespace Ecom.Data.Models
{
    public partial class UserRoles
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual Users User { get; set; }
    }
}
