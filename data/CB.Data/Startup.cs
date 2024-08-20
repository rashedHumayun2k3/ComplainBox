using CB.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CB.Data.Repositories;
using CB.Data.Entities;
using CB.Data.Repositories.Implementations;


namespace CB.Data
{
	public static class Startup
	{
		public static IServiceCollection AddCBData(this IServiceCollection services, IConfiguration configuration)
		{
			// Add services to the container.
			services.AddSingleton<EcDbContext>();
			services.Configure<ConnectionStringOptions>(configuration.GetSection(ConnectionStringOptions.Position));

			services.AddSingleton<EcMongoDbContext>();
			services.Configure<MongoDbConfig>(configuration.GetSection("MongoDB"));

			AddEcRepositories(services, configuration);
			return services;
		}
		public static IServiceCollection AddEcRepositories(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IProductRepository, ProductRepository>();
            return services;
		}
	}
}
