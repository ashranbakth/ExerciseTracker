using ExerciseTracker.Api.Models;

namespace ExerciseTracker.Api.Services;

public interface IUserService
{
    Task<List<User>> GetAllAsync();
}