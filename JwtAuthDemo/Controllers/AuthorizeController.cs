using JwtAuthDemo.Data;
using JwtAuthDemo.Models;
using JwtAuthDemo.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IConfiguration _configuration;
        private readonly TokenService _tokenService;


        public AuthorizeController(ApplicationDBContext context, IConfiguration configuration, TokenService tokenService)
        {
            _context = context;
            _configuration = configuration;
            _tokenService = tokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(new { message = "User registered successfully" });
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            var dbUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);
            if (dbUser == null)
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }
            var accessToken = _tokenService.GenerateAccessToken(dbUser);
            var refreshToken = _tokenService.GenerateRefreshToken(dbUser.Id);

            return Ok(new { accessToken, refreshToken });
        }


        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] TokenModel model)
        {
            var refreshToken = _tokenService.GetRefreshToken(model.RefreshToken);
            if (refreshToken == null)
            {
                return Unauthorized(new { message = "Invalid refresh token" });
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == refreshToken.UserId);
            if (user == null)
            {
                return Unauthorized(new { message = "Invalid refresh token" });
            }

            var newAccessToken = _tokenService.GenerateAccessToken(user);
            var newRefreshToken = _tokenService.GenerateRefreshToken(user.Id);

            // Revoke the old refresh token
            _tokenService.RevokeRefreshToken(refreshToken.RefreshUserToken);

            return Ok(new { accessToken = newAccessToken, refreshToken = newRefreshToken });
        }
    }
}
