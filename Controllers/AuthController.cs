using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microloand.API.Services;

namespace Microloand.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtService _jwt;

        public AuthController(UserManager<IdentityUser> userManager, JwtService jwt)
        {
            _userManager = userManager;
            _jwt = jwt;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            var user = new IdentityUser { UserName = username };
            var result = await _userManager.CreateAsync(user, password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("User created");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null || !await _userManager.CheckPasswordAsync(user, password))
                return Unauthorized();

            var token = _jwt.GenerateToken(username);

            return Ok(new { token });
        }
    }
}