namespace JwtAuthDemo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public required string Password { get; set; }
        public required string? Role { get; set; } 

        public ICollection<RefreshToken>? RefreshTokens { get; set; }
    }
}
