using AutoMapper;
using CB.Business.Managers;
using CB.Business.Managers.Implementations;
using CB.Business.Mappers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CB.Data;
using CB.Data.Repositories.Implementations;
using CB.Data.Repositories;

namespace CB.Business
{
	public static class Startup
	{
		public static IServiceCollection AddCBBusiness(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton(provider => new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<ProductMapper>();
                cfg.AddProfile<CategoryMapper>();
				cfg.AddProfile<AuthorMapper>();
			}).CreateMapper());

			services.AddCBData(configuration);
			AddEcManegers(services, configuration);
			return services;
		}
		public static IServiceCollection AddEcManegers(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IProductManager, ProductManager>();
        
            return services;
		}
	}
}