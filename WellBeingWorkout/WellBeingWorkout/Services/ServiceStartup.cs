namespace WellBeingWorkout.Services
{
    public static class ServiceStartup
    {
        public static IServiceCollection ServiceRegister(this IServiceCollection services)
        {
            services.AddScoped<IChallengeService, ChallengeService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserChallengeService, UserChallengeService>();

            return services;
        }
    }
}
