using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service
{
    public class OrderMasterService : IOrderMasterService
    {
        private readonly IOrderMasterRepository _orderMasterRepository;
        public OrderMasterService(IOrderMasterRepository orderMasterRepository)
        {
            _orderMasterRepository = orderMasterRepository;
        }
        public int Add(OrderMasterAddRequest request)
        {
            return _orderMasterRepository.Add(request);
        }
    }
}
