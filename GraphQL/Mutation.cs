using System.Threading.Tasks;
using GraphqlWallets.Core.Entities;
using GraphqlWallets.GraphQL.GraphTypes.Inputs;
using GraphqlWallets.Infrastructure.Data;
using HotChocolate;

namespace GraphqlWallets.GraphQL
{
    public class Mutation
    {
        public async Task<Customer> CreateCustomer([Service]CustomerRepository repository, CreateCustomerInput input)
        {
            var customer = new Customer
            {
                Firstname = input.Firstname,
                Lastname = input.Lastname
            };
            var result = await repository.Add(customer);
            return result;
        }
    }
}