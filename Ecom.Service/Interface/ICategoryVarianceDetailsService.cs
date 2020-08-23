using Ecom.Models.Web.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface ICategoryVarianceDetailsService
    {
        bool Create(List<CategoryVarianceDetailsAddRequest> addRequests);
    }
}
