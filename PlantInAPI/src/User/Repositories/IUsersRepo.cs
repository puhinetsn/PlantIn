using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.src.User.Repositories
{
    public interface IUsersRepo
    {
        Task Register(UserModel newUser);
        Task<UserModel> LogIn(UserLoginRequestDTO userData);
        Task<UserModel> FindUserById(Guid id);
        Task<bool> FindUser(string email);
        Task<UserRefreshTokens> FindUserRefreshToken(Guid id);
        Task<string> AddUserRefreshToken(UserRefreshTokens userTokenData);

    }
}
