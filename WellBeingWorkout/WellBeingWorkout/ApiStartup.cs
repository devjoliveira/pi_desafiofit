using WellBeingWorkout.Data;
using WellBeingWorkout.Services;

namespace WellBeingWorkout
{
    public static class ApiStartup
    {
        public static IServiceCollection ApiRegister(this WebApplicationBuilder webApplicationBuilder)
        {
            IServiceCollection services = webApplicationBuilder.Services;
            services.ServiceRegister();
            return services;
        }
    }
}
