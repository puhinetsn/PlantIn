using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantInAPI.src.User.DTOs;
using PlantInAPI.src.User.Services;

namespace PlantInAPI.src.User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersService usersServ;
        private readonly IValidator<UserCreateRequestDTO> validator;
        private readonly IAuthService auth;

        public UserController(
            IUsersService usersService, 
            IValidator<UserCreateRequestDTO> userValidator, 
            IAuthService authServ)
        {
            usersServ = usersService;
            validator = userValidator;
            auth = authServ; 
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Register(UserCreateRequestDTO newUser)
        {
            var isNewUser = await usersServ.FindUserAsync(newUser.Email);
            if(isNewUser)
            {
                return BadRequest("user already exists");
            }
            var result = await validator.ValidateAsync(newUser);

            if (!result.IsValid)
                return ValidationProblem(new ValidationProblemDetails(result.ToDictionary()));

            var user = await usersServ.AddUserAsync(newUser);
            var createdUser = new UserCreateResponseDTO(user);

            return StatusCode(201, createdUser);
        }

        [HttpPost("login")]
        public async Task<ActionResult<TokenResponseDTO>> LogIn(UserLoginRequestDTO userData)
        {
            var token = await usersServ.LogInAsync(userData);

            if(token == null)
            {
                return BadRequest("Invalid data");
            }

            return Ok(token);
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<TokenResponseDTO>> RefreshToken(RefreshTokenRequestDTO request)
        {
            var result = await usersServ.RefreshTokens(request);
            if(result is null || result.RefreshToken is null || result.AccessToken is null)
            {
                return Unauthorized("Invalid refresh token");
            }

            return Ok(result);
        }

        [Authorize(Roles = "True")]
        [HttpGet("admin-only")]
        public async Task<ActionResult<string>> AdminBS()
        {
            return Ok("You are an admin");
        }
    }
}
