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
        if(String.IsNullOrEmpty(user.Password) || 
            String.IsNullOrEmpty(user.ConfirmPassword) || 
            String.IsNullOrEmpty(user.Name) ||
            String.IsNullOrEmpty(user.Email)) 
            throw new Exception("Todos os dados são obrigatórios");
       
        if (user.Password != user.ConfirmPassword)
            throw new Exception("As senhas são difererentes");

        var savedUser = await _context.User.FirstOrDefaultAsync(x => x.Email == user.Email);
        if (savedUser != null)
            throw new Exception("Email já cadastrado");
        
        user.Level = 1;
        _context.User.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User> LoginUserAsync (User user)
    {
        if (String.IsNullOrEmpty(user.Password) || String.IsNullOrEmpty(user.Email))
            throw new Exception("Todos os dados são obrigatórios");

        var userWithSameEmail = await _context.User.FirstOrDefaultAsync(x => x.Email == user.Email);

        if (userWithSameEmail == null) 
            throw new Exception("Login inválido");

        if(userWithSameEmail.Password != user.Password)
            throw new Exception("Login inválido");

        return userWithSameEmail;
    }
}

