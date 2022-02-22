using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VY.G.Business.Contracts.Services;
using VY.G.Business.Contracts.Validations;
using VY.G.Business.Impl.Services;
using VY.G.Business.Impl.Validations;
using VY.G.Data.Impl.Extensions;

namespace VY.G.Business.Impl.Extensions
{
    public static class BusinessServiceExtension
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDataServices(configuration);

            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IValidation, Validation>();

            return services;
        }
    }
}
