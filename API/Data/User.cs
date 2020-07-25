namespace DeliverIt.Data
{
    public class User
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public string CompanyId { get; set; }

        public Company Company { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longtitude { get; set; }
    }
}