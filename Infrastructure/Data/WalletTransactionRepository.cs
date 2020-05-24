using GraphqlWallets.Core.Entities;
using GraphqlWallets.Infrastructure.Persistence;

namespace GraphqlWallets.Infrastructure.Data
{
    public class WalletTransactionRepository : Repository<WalletTransaction, WalletDbContext>
    {
        public WalletTransactionRepository(WalletDbContext context) : base(context)
        {

        }
    }
}