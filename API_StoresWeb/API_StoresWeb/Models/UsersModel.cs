namespace API_StoresWeb.Models
{
    public class UsersModel
    {
        public Guid ID { get; set; }
        public required string Code { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public bool HasPassword { get; set; }
        public bool HasEmail { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public int? Gender { get; set; }
        public string? AvtImage { get; set; }
    }
}
