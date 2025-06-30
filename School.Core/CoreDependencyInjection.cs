using Microsoft.Extensions.DependencyInjection;

namespace School.Core
{
    public static class ReporsitoresDependencyInjection
    {
        public static IServiceCollection AddCoreDependecyInjection(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ReporsitoresDependencyInjection).Assembly));
            return services;
        }
    }
}
