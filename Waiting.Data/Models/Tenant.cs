namespace Waiting.Data.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
