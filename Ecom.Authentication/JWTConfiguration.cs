using Ecom.Models.Enums;
using Ecom.Utility;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace Ecom.Authentication
{
    public static class JWTConfiguration
    {
        public static void AddJWTAuthentication(this IServiceCollection services, ConfigurationOption configurationOption)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configurationOption.Jwt.Issuer,
                    ValidAudience = configurationOption.Jwt.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configurationOption.Jwt.SecretKey)),
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        public static void AddJWTAuthorization(this IServiceCollection services)
        {
            services.AddScoped<IJwtHelper, JwtHelper>();
            services.AddAuthorization(config =>
            {
                config.AddPolicy(RoleType.Admin.Description(), Policies.AdminPolicy());
                config.AddPolicy(RoleType.User.Description(), Policies.UserPolicy());
            });
        }

        public static void AddJWTTokenReader(this IServiceCollection services)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IJwtReader, JwtReader>();
        }
    }
}
