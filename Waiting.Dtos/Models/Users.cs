namespace Waiting.Dto.Models
{
    public class Users
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
    }
}
