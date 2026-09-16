using ExerciseTracker.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _service;

    public UsersController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var exercises = await _service.GetAllAsync();

        return Ok(exercises);
    }
}