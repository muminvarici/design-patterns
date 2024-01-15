using Microsoft.AspNetCore.Mvc;
using SimpleApi.Services.Abstractions;

namespace SimpleApi.Controllers;

[Route("api/[controller]")] //TODO we need to provide versioning later
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var user = await _userService.GetUserById(id);
        if (user == null)
            return NotFound();
        return Ok(user); //TODO  we need to map domain object to another type later
    }
}