using ExerciseTracker.Api.Models;

namespace ExerciseTracker.Api.Repositories;

public interface IExerciseRepository
{
    Task<List<Exercise>> GetAllAsync();
}