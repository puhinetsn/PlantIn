using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.src.User.Services
{
    public interface IUsersService
    {
        Task<UserModel> AddUserAsync(UserCreateRequestDTO userDto);
        Task<TokenResponseDTO?> LogInAsync(UserLoginRequestDTO userDto);
        Task<bool> FindUserAsync(string email);
        Task<TokenResponseDTO?> RefreshTokens(RefreshTokenRequestDTO request);
    }
}
