using Autofac;
using DI_IoC_Autofac_Net_Core.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace DI_IoC_Autofac_Net_Core
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("test", new OpenApiInfo
                {
                    Title = "DI_IoC_Autofac_Net_Core",
                    Version = "TEST",
                    Description = "Test api for implementing and testing Autofac",
                    Contact = new OpenApiContact
                    {
                        Name = "CrishFK",
                        Email = string.Empty,
                        Url = new Uri("https://github.com/CrishFK"),
                    },
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/test/swagger.json", "DI_IoC_Autofac_Net_Core Test");
            });

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new LifeCycleModule());
        }
    }
}
