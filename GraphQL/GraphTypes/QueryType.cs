using HotChocolate.Types;

namespace GraphqlWallets.GraphQL.GraphTypes
{
    public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor.Field(t => t.GetCustomers(default))
                .Type<NonNullType<ListType<NonNullType<CustomerType>>>>();

            descriptor.Field(t => t.GetCustomer(default, default))
                .Type<CustomerType>()
                .Argument("customerid", a => a.Type<NonNullType<LongType>>());
        }
    }
}