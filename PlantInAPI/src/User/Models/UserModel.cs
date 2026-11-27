using System.ComponentModel.DataAnnotations.Schema;

namespace PlantInAPI.src.User.Models
{
    public class UserModel
    {
        public Guid Id { get; private set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public int XP { get; set; }
        public int StreakCount { get; set; }
        public bool IsAdmin { get; set; }

    }
}
