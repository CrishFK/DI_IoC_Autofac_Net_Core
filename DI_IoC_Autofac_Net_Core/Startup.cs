using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;

namespace DI_IoC_Autofac_Net_Core
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
            services.AddControllers();

            services.AddLogging(loggingBuilder => loggingBuilder.AddConsole());

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


        //This method gets called by the runtime.Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/test/swagger.json", "DI_IoC_Autofac_Net_Core Test");

                //c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
