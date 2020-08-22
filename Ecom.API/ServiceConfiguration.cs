using Ecom.Data;
using Ecom.Data.Implementation.Repository;
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
            services.AddScoped<ICategoryMasterRepository, CategoryMasterRepository>();
            services.AddScoped<IVarianceMasterService, VarianceMasterService>();
            services.AddScoped<IVarianceMasterRepository, VarianceMasterRepository>();
            services.AddScoped<ICategoryReturnMasterService, CategoryReturnMasterService>();
            services.AddScoped<ICategoryReturnMasterRepository, CategoryReturnMasterRepository>();
        }
    }
}
