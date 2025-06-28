using Microsoft.Extensions.DependencyInjection;
using School.Service.Interfaces;
using School.Service.Services;

namespace School.Service
{
    public static class ServicesDependencyInjection
    {
        public static IServiceCollection AddSchoolServicesDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            return services;
        }
    }
}
