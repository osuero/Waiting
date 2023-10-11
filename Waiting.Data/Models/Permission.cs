namespace Waiting.Data.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
