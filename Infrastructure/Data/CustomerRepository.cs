using GraphqlWallets.Core.Entities;
using GraphqlWallets.Infrastructure.Persistence;

namespace GraphqlWallets.Infrastructure.Data
{
    public class CustomerRepository : Repository<Customer, WalletDbContext>
    {
        public CustomerRepository(WalletDbContext context): base(context)
        {

        }
    }
}