namespace Waiting.Data.Models
{
    public class RolePermission
    {
        public string RoleId { get; set; }
        public IdentityRole Role { get; set; }
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
