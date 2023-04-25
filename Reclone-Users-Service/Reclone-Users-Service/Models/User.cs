namespace Reclone_Users_Service.Models
{
    public class User
    {
        public long Id { get; set; }
        public string AuthId { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Bio { get; set; }

        public string? ProfilePictureUrl { get; set; }


    }
}
