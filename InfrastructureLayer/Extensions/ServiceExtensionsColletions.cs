using DomainLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InfrastructureLayer;

public static class ServiceExtensionsColletions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    { 
        
            services.AddDbContext<TopFilmsDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TopFilmsViewerDb")));
            services.AddScoped<ITopFilmsViewer,TopFilmsViewerRepository>();
    }



}
