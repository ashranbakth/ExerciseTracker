using ExerciseTracker.Api.Data;
using ExerciseTracker.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ExerciseTracker.Api.Repositories;

public class ExerciseRepository : IExerciseRepository
{
    private readonly AppDbContext _context;

    public ExerciseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Exercise>> GetAllAsync()
    {
        return await _context.Exercises.ToListAsync();
    }
}