using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers()
                    .AddApplicationPart(typeof(Presentation.Controller.CoreControllerBase).Assembly);
            // Test
            return services;
        }
    }
}
