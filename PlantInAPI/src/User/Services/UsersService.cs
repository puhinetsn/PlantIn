using Microsoft.AspNetCore.Identity;
using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;
using PlantInAPI.src.User.Repositories;

namespace PlantInAPI.src.User.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepo usersRepo;
        public UsersService(IUsersRepo repo) => usersRepo = repo;

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
    }
}
