using AutoWrapper;
using Ecom.Authentication;
using Ecom.Utility;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.API
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
            // Add Cors policy
            services.AddCorsPolicy();
            services.Configure<ConfigurationOption>(Configuration);

            var configuration = new ConfigurationOption();
            Configuration.Bind(configuration);

            services.AddControllers();

            // Add JWT authentication, authorization and reader
            services.AddJWTAuthentication(configuration);
            services.AddJWTAuthorization();
            services.AddJWTTokenReader();

            // Add services and repository services in custom service
            services.AddCustomServices();

            // Add fluent validation
            services.AddFluentValidation();

            // Add swagger gen
            services.AddSwagger();

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCorsPolicy();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseApiResponseAndExceptionWrapper(new AutoWrapperOptions { IsDebug = true });

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ECOM API V1");
            });

           
        }
    }
}
