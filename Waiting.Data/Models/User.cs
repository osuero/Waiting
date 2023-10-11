namespace Waiting.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActived { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
