using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microloand.API.Services;

namespace Microloand.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        // TODO: Inject UserManager<IdentityUser> and JwtService via constructor

        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtService _jwtService;

        public AuthController(UserManager<IdentityUser> userManager, JwtService jwtService)
        {
            _userManager = userManager;
            _jwtService = jwtService;
        }

        // ===============================
        // 🔹 Register API
        // ===============================
        // TODO:
        // 1. Accept username and password
        // 2. Create new IdentityUser
        // 3. Use _userManager.CreateAsync()
        // 4. Return success or error

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            return Ok("Implement Register");
        }

        // ===============================
        // 🔹 Login API
        // ===============================
        // TODO:
        // 1. Find user using _userManager.FindByNameAsync()
        // 2. Validate password using CheckPasswordAsync()
        // 3. Generate JWT token using JwtService
        // 4. Return token

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            return Ok("Implement Login with JWT");
        }
    }
}