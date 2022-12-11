using Dating.Core.Services;
using Dating.UI;
using Dating.UI.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Dating.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;
    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet]
    public async Task<ActionResult<ResponseData<IEnumerable<User>>>> Get()
    {
        return Ok(await _usersService.GetUsersAsync());
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ResponseData<User>>> GetSingle(Guid id)
    {
        var response = await _usersService.GetSingleUserAsync(id);
        if (response.HasError())
        {
            return NotFound(response);
        }
        return Ok(response);
    }
}
