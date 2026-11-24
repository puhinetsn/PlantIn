using PlantInAPI.src.User.Models;

namespace PlantInAPI.src.User.Repositories
{
    public interface IUsersRepo
    {
        Task Register(UserModel newUser);
    }
}
