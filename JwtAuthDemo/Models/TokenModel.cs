namespace JwtAuthDemo.Models
{
    public class TokenModel
    {
        public required string Token { get; set; }
        public required string RefreshToken { get; set; }
    }
}
