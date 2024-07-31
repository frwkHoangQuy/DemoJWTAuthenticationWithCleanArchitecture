using Application.Contracts;
using Application.DTOs;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class User : ControllerBase
{
    private readonly IUser user;

    public User(IUser user)
    {
        this.user = user;
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResponse>> LogUserIn(LoginDTO loginDTO)
    {
        var result = await user.LoginUserAsync(loginDTO);
        return Ok(result);
    }

    [HttpPost("register")]
    public async Task<ActionResult<LoginResponse>> RegisterUser(RegisterUserDTO registerUserDTO)
    {
        var result = await user.RegistrationUserAsync(registerUserDTO);
        return Ok(result);
    }

}
