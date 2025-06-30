using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Interfaces;
using School.Infrastructure.Repositories;

namespace School.Infrastructure
{
    public static class ReporsitoresDependencyInjection
    {
        public static IServiceCollection AddReporsitoriesDepenecyInjection(this IServiceCollection services)
        {
            services.AddTransient<IStudentReporsitory, StudentReporsitory>();
            return services;
        }
    }
}
