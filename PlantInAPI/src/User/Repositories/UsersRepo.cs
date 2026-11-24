using Microsoft.EntityFrameworkCore;
using PlantInAPI.Data;
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
    }
}
