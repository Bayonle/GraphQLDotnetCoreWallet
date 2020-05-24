using GraphqlWallets.Core.Entities;
using GraphqlWallets.Infrastructure.Persistence;

namespace GraphqlWallets.Infrastructure.Data
{
    public class WalletRepository : Repository<Wallet, WalletDbContext>
    {
        public WalletRepository(WalletDbContext context) : base(context)
        {

        }
    }
}