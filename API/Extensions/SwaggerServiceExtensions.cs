using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1",new OpenApiInfo {
                    Title= "eShop API", Version ="v1"
                } );
            });
            return services;
        }
        public static IApplicationBuilder UserSwaggerDocumentation(this IApplicationBuilder app)
        {
             app.UseSwagger();
            app.UseSwaggerUI(x=>{x
            .SwaggerEndpoint("/swagger/v1/swagger.json","eShop API v1");});
            return app;
        }
    }
}