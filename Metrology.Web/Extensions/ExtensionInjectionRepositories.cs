using Metrology.Data.Repositories;

namespace Metrology.Web.Extensions;

public static class ExtensionInjectionRepositories
{
    public static void Inject(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MetrologyConnection") ??
                               throw new InvalidOperationException("Connection string 'PostgreSQL' not found in configuration.");
        
        services.AddNpgsqlDataSource(connectionString);
        
        services.AddScoped<EmployeeRepository>();
        services.AddScoped<DepartmentRepository>();
        services.AddScoped<PositionsRepository>();
    }
}