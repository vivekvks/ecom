using Ecom.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface IOrderMasterService
    {
        int Add(OrderMasterAddRequest request);
    }
}
