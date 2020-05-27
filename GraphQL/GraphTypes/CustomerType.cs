// using GraphQL.Types;
using GraphqlWallets.Core.Entities;
using HotChocolate.Types;

namespace GraphqlWallets.GraphQL.GraphTypes
{
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            Name = "Customer";
            Description = "A customer";

            descriptor.Field(x => x.Id).Type<NonNullType<LongType>>().Description("Customer Id");
            descriptor.Field(x => x.Firstname).Type<NonNullType<StringType>>().Description("Customer's firstname");
            descriptor.Field(x => x.Lastname).Type<NonNullType<StringType>>().Description("Customer's lastname");
            descriptor.Field(x => x.Registered).Type<NonNullType<DateTimeType>>().Description("Customer's registration date");

        }
    }
}