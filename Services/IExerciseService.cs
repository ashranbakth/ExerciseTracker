using ExerciseTracker.Api.Models;

namespace ExerciseTracker.Api.Services;

public interface IExerciseService
{
    Task<List<Exercise>> GetAllAsync();
}