namespace PlantInAPI.src.User.DTOs
{
    public record UserCreateRequestDTO
    (
        string Email,
        string Password,
        string Name
    );
}
