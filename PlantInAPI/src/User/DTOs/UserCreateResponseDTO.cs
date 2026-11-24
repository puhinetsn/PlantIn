using PlantInAPI.src.User.Models;

namespace PlantInAPI.src.User.DTOs
{
    public record UserCreateResponseDTO
    (
        string Email,
        string Name,
        int XP,
        int StreakCount,
        bool IsAdmin
    )
    {
        public UserCreateResponseDTO(UserModel User) : this(User.Email, User.Name, User.XP, User.StreakCount, User.IsAdmin) { }
    }
}
