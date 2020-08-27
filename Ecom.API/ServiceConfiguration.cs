using Ecom.API.Attributes;
using Ecom.Authentication;
using Ecom.Data.Implementation.Repository;
using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Service;
using Ecom.Service.Interface;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Ecom.API
{
    /// <summary>
    /// inject custom services and repository service
    /// </summary>
    public static class ServiceConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ICategoryMasterService, CategoryMasterService>();
            services.AddScoped<ICategoryMasterRepository, CategoryMasterRepository>();
            services.AddScoped<IVarianceMasterService, VarianceMasterService>();
            services.AddScoped<IVarianceMasterRepository, VarianceMasterRepository>();
            services.AddScoped<ICategoryReturnMasterService, CategoryReturnMasterService>();
            services.AddScoped<ICategoryReturnMasterRepository, CategoryReturnMasterRepository>();
            services.AddScoped<ICategoryVarianceDetailsService, CategoryVarianceDetailsService>();
            services.AddScoped<ICategoryVarianceDetailsRepository, CategoryVarianceDetailsRepository>();
            services.AddScoped<IUserMasterRepository, UserMasterRepository>();
            services.AddScoped<IUserMasterService, UserMasterService>();
            services.AddScoped<ICategoryAttributeMasterService, CategoryAttributeMasterService>();
            services.AddScoped<ICategoryAttributeMasterRepository, CategoryAttributeMasterRepository>();
            services.AddScoped<ICompanyMasterRepository, CompanyMasterRepository>();
            services.AddScoped<ICompanyMasterService, CompanyMasterService>();
        }

        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddMvc(op => op.Filters.Add(typeof(ValidateFilterAttribute)))
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<FluentAssemblyCommon>());
        }

        public static void AddSwagger(this IServiceCollection services)
        {
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ECOM API",
                    Version = "v1"
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                  new OpenApiSecurityScheme
                  {
                    Reference = new OpenApiReference
                    {
                      Type = ReferenceType.SecurityScheme,
                      Id = "Bearer"
                    }
                   },
                   new string[] { }
                 }});
            });
        }
    }
}
