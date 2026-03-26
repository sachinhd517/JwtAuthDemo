namespace JwtAuthDemo.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key to User

        public required string TokenId { get; set; }
        public required string RefreshUserToken {  get; set; }
        public DateTime ExpiryDate { get; set; }
        public required User User { get; set; } // Navigation property to User

    }
}
