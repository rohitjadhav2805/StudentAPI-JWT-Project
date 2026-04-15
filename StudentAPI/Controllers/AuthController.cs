using Microsoft.AspNetCore.Mvc;
using StudentAPI.Helpers;
using StudentAPI.Models;

namespace StudentAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtHelper _jwt;

    public AuthController(IConfiguration config)
    {
        _jwt = new JwtHelper(config);
    }

    [HttpPost("login")]
    public IActionResult Login(User user)
    {
        if (user.Username == "admin" && user.Password == "admin123")
        {
            var token = _jwt.GenerateToken(user.Username);
            return Ok(new { token });
        }

        return Unauthorized("Invalid credentials");
    }
}