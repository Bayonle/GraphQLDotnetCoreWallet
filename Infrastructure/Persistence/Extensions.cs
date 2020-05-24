using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphqlWallets.Infrastructure.Persistence
{
    public static class Extensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WalletDbContext>(option => {
                option.UseSqlServer(configuration["DefaultConnection"]);
            });
            return services;
        }
    }
}