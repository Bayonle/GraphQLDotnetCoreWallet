using System;
using GraphqlWallets.Infrastructure.Data;
using GraphqlWallets.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GraphqlWallets.GraphQL;
using HotChocolate;
using HotChocolate.AspNetCore;
using GraphqlWallets.GraphQL.GraphTypes;

namespace GraphqlWallets
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQL(option => {
                return SchemaBuilder.New()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .Create();
            });
            // services.AddGraphQL((options, provider) => {
            //     options.EnableMetrics = Environment.IsDevelopment();
            //     options.ExposeExceptions = Environment.IsDevelopment();
            // });

            services.AddControllers();
            services.AddPersistence(Configuration);
            services.AddRepositories();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app
                .UseGraphQLHttpPost(new HttpPostMiddlewareOptions{Path = "/graphql"})
                .UseGraphQLHttpGetSchema(new HttpGetSchemaMiddlewareOptions { Path = "/graphql/schema" });

            app.UseGraphiql("/graphiql", options =>
            {
                options.GraphQlEndpoint = "/graphql";
            });            // app.UseGraphQL<WalletSchema>();
        }
    }
}
