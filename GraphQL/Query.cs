using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphqlWallets.Core.Entities;
using GraphqlWallets.Infrastructure.Data;
using HotChocolate;

namespace GraphqlWallets.GraphQL
{
    public class Query
    {
        public async Task<List<Customer>> GetCustomers([Service]CustomerRepository repository)
        {
            return await repository.GetAll();
        }

        public async Task<Customer> GetCustomer([Service]CustomerRepository repository, long id)
        {
            return await repository.Get(id);
        }
    }
}