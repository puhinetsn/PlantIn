using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.src.User.Services
{
    public interface IUsersService
    {
        Task<UserModel> AddUserAsync(UserCreateRequestDTO userDto);
    }
}
