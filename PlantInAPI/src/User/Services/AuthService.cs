using Microsoft.IdentityModel.Tokens;
using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Models;
using PlantInAPI.src.User.Repositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PlantInAPI.src.User.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IUsersRepo usersRepo;

        public AuthService(IConfiguration configuration, IUsersRepo repo)
        {
            _configuration = configuration;
            usersRepo = repo;
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create(); rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        public async Task<string> GenerateAndSaveRefreshTokenAsync(UserModel userData)
        {
            var refreshToken = GenerateRefreshToken();
            var newUserRefreshToken = new UserRefreshTokens
            {
                UserId = userData.Id,
                RefreshToken = refreshToken,
                RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7)
            };

            await usersRepo.AddUserRefreshToken(newUserRefreshToken);

            return refreshToken;
        }

        public string GenerateToken(UserModel userData)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userData.Name),
                new Claim(ClaimTypes.NameIdentifier, userData.Id.ToString()),
                new Claim(ClaimTypes.Role, userData.IsAdmin.ToString()) 
            };

            var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_configuration.GetValue<string>("AppSettings:Token")!));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);


            var tokenDescriptor = new JwtSecurityToken(
                issuer: _configuration.GetValue<string>("AppSettings:Issuer"),
                audience: _configuration.GetValue<string>("AppSettings:Audience"), claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }

        public async Task<UserRefreshTokens?> ValidateRefreshToken(Guid id, string refreshToken)
        {
            var userToken = await usersRepo.FindUserRefreshToken(id);
            if(userToken is null || userToken.RefreshToken != refreshToken ||
                userToken.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                return null;
            }

            return userToken;
        }
    }
}
