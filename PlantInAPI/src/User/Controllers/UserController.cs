using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using PlantInAPI.src.PlantsSpecies.DTOs;
using PlantInAPI.src.PlantsSpecies.Service;
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

        public UserController(IUsersService usersService, IValidator<UserCreateRequestDTO> userValidator)
        {
            usersServ = usersService;
            validator = userValidator;
        }

        [HttpPost("signin")]
        public async Task<IActionResult> Register(UserCreateRequestDTO newUser)
        {
            var result = await validator.ValidateAsync(newUser);

            if (!result.IsValid)
                return ValidationProblem(new ValidationProblemDetails(result.ToDictionary()));

            var user = await usersServ.AddUserAsync(newUser);
            var createdUser = new UserCreateResponseDTO(user);

            return StatusCode(201, createdUser);
        }
    }
}
