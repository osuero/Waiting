namespace Waiting.Data.Models
{
    public class ApplicationUser: User
    {
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
