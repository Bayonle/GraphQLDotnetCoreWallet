using GraphqlWallets.GraphQL.GraphTypes.Inputs;
using HotChocolate.Types;

namespace GraphqlWallets.GraphQL.GraphTypes.InputTypes
{
    public class CreateCustomerInputType : InputObjectType<CreateCustomerInput>
    {
        protected override void Configure(IInputObjectTypeDescriptor<CreateCustomerInput> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(x => x.Firstname).Type<NonNullType<StringType>>();
            descriptor.Field(x => x.Lastname).Type<NonNullType<StringType>>();
        }
    }
}