using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.src.User.Services
{
    public interface IAuthService
    {
        string GenerateToken(UserModel userData);
        Task<string> GenerateAndSaveRefreshTokenAsync(UserModel userData);
        Task<UserRefreshTokens?> ValidateRefreshToken(Guid id, string refreshToken)
    }
}
