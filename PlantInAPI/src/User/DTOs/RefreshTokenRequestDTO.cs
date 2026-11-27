namespace PlantInAPI.src.User.DTOs
{
    public record RefreshTokenRequestDTO
    (
        Guid UserId,
        string RefreshToken
    );
}
