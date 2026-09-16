using ExerciseTracker.Api.Models;

namespace ExerciseTracker.Api.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync();
}