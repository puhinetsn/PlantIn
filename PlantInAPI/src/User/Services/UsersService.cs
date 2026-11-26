using Microsoft.AspNetCore.Identity;
using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;
using PlantInAPI.src.User.Repositories;

namespace PlantInAPI.src.User.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepo usersRepo;
        private readonly IAuthService auth;
        public UsersService(IUsersRepo repo, IAuthService authServ) {
            usersRepo = repo;
            auth = authServ;
        } 

        public async Task<UserModel> AddUserAsync(UserCreateRequestDTO userDto)
        {
            var newUser = new UserModel
            {
                Email = userDto.Email,
                PasswordHash = userDto.Password,
                Name = userDto.Name,
                XP = 0,
                StreakCount = 0,
                IsAdmin = false
            };

            var hasher = new PasswordHasher<UserModel>();
            string hash = hasher.HashPassword(newUser, newUser.PasswordHash);
            newUser.PasswordHash = hash;

            await usersRepo.Register(newUser);

            return newUser;
        }

        public async Task<bool> FindUserAsync(string email)
        {
            return await usersRepo.FindUser(email);
        }

        public async Task<TokenResponseDTO?> LogInAsync(UserLoginRequestDTO userDto)
        {
            var user = await usersRepo.LogIn(userDto);

            if (user == null)
            {
                return null;
            }
            if (new PasswordHasher<UserModel>().VerifyHashedPassword(user, user.PasswordHash, userDto.Password)
                == PasswordVerificationResult.Failed)
            {
                return null;
            }
            TokenResponseDTO tokenData = await CreateTokenResponseData(user);

            return tokenData;
        }

        public async Task<TokenResponseDTO?> RefreshTokens(RefreshTokenRequestDTO request)
        {
            var tokenData = await auth.ValidateRefreshToken(request.UserId, request.RefreshToken);
            if (tokenData is null)
            {
                return null;
            }

            var user = await usersRepo.FindUserById(request.UserId);

            var refreshedTokenData = await CreateTokenResponseData(user);
            return refreshedTokenData;
        }

        private async Task<TokenResponseDTO> CreateTokenResponseData(UserModel user)
        {
            return new TokenResponseDTO
            (
                auth.GenerateToken(user),
                await auth.GenerateAndSaveRefreshTokenAsync(user)
            );
        }
    }
}
