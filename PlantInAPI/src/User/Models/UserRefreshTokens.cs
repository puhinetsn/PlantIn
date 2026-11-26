namespace PlantInAPI.src.User.Models
{
    public class UserRefreshTokens
    {
        public Guid UserId { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
