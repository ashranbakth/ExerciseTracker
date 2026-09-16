using ExerciseTracker.Api.Data;
using ExerciseTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Api.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }
}