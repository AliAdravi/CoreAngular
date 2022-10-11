using Interview.Services.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Interview.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRequiredServices(
            this IServiceCollection services,
            IConfiguration configuratino)
        {

            // Services
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IBlogService, BlogService>();
            
            return services;
        }
    }
}