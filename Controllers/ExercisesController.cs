using ExerciseTracker.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExercisesController : ControllerBase
{
    private readonly IExerciseService _service;

    public ExercisesController(IExerciseService service)
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