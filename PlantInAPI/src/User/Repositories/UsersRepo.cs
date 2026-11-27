using Microsoft.EntityFrameworkCore;
using PlantInAPI.Data;
using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;

namespace PlantInAPI.src.User.Repositories
{
    public class UsersRepo : IUsersRepo
    {
        private readonly PlantInContext plantDB;
        public UsersRepo(PlantInContext db) => plantDB = db;
        public async Task Register(UserModel newUser)
        {
            await plantDB.Users.AddAsync(newUser);
            await plantDB.SaveChangesAsync();
        }

        public async Task<UserModel> LogIn(UserLoginRequestDTO userData)
        {
            var email = userData.Email.Trim().ToLowerInvariant();

            var user = await plantDB.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Email == email);
            return user;
        }

        public async Task<bool> FindUser(string email)
        {
            return await plantDB.Users.AnyAsync(u => u.Email == email);
            
        }

        public async Task<string> AddUserRefreshToken(UserRefreshTokens userTokenData)
        {
           await plantDB.UserRefreshTokens.AddAsync(userTokenData);
           await plantDB.SaveChangesAsync();
           return userTokenData.RefreshToken;
        }

        public async Task<UserRefreshTokens> FindUserRefreshToken(Guid id)
        {
            return await plantDB.UserRefreshTokens.FindAsync(id);
        }

        public async Task<UserModel> FindUserById(Guid id)
        {
            return await plantDB.Users.FindAsync(id);
        }
    }
}
