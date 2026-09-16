using ExerciseTracker.Api.Models;
using ExerciseTracker.Api.Repositories;

namespace ExerciseTracker.Api.Services;

public class UserService: IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }
}