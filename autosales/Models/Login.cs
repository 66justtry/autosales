namespace autosales.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = String.Empty;
        public int UserId { get; set; }
        public virtual User? UserNavigation { get; set; }
    }
}
