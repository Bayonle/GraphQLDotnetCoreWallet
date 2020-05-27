using GraphqlWallets.GraphQL.GraphTypes.InputTypes;
using HotChocolate.Types;

namespace GraphqlWallets.GraphQL.GraphTypes
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.CreateCustomer(default, default))
                .Type<CustomerType>()
                .Argument("input", a => a.Type<CreateCustomerInputType>());
        }
    }
}