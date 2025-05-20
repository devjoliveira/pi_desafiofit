using Microsoft.EntityFrameworkCore;
using WellBeingWorkout.Data;

public class UserService : IUserService
{
    private readonly WellBeingWorkoutContext _context;

    public UserService(WellBeingWorkoutContext context)
    {
        _context = context;
    }

    public async Task SignUpUserAsync (User user)
    {
        user.Level = 1;
        _context.User.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User> LoginUserAsync (User user)
    {
        var userWithSameEmail = await _context.User.FirstOrDefaultAsync(x => x.Email == user.Email);

        if (userWithSameEmail == null) 
            throw new Exception("Usuário não encontrado");
        
        return userWithSameEmail;
    }
}

