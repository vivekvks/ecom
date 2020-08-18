using Ecom.Data;
using Ecom.Data.Interface;
using Ecom.Service;
using Ecom.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.API
{
    /// <summary>
    /// inject custom services and repository service
    /// </summary>
    public static class ServiceConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryMasterService, CategoryMasterService>();
            services.AddScoped<ICategoryMasterRepository, Ecom.Data.Implementation.Repository.CategoryMasterRepository>();
        }
    }
}
