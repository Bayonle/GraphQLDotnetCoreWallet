using Microsoft.Extensions.DependencyInjection;

namespace GraphqlWallets.Infrastructure.Data
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<CustomerRepository>();
            services.AddScoped<WalletRepository>();
            services.AddScoped<WalletTransactionRepository>();

            return services;
        }
    }
}