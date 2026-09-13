using ExerciseTracker.Api.Models;
using ExerciseTracker.Api.Repositories;

namespace ExerciseTracker.Api.Services;

public class ExerciseService: IExerciseService
{
    private readonly IExerciseRepository _repository;

    public ExerciseService(IExerciseRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Exercise>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }
}