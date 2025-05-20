public interface IUserService
{
    Task SignUpUserAsync(User user);
    Task<User> LoginUserAsync(User user);
}
