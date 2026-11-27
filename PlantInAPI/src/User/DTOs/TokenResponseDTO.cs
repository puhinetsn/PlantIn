namespace PlantInAPI.src.User.DTOs
{
    public record TokenResponseDTO
    (
        string AccessToken,
        string RefreshToken
    );
}
