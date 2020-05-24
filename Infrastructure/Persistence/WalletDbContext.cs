using Microsoft.EntityFrameworkCore;

namespace GraphqlWallets.Infrastructure.Persistence
{
    public class WalletDbContext : DbContext
    {
        public WalletDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}