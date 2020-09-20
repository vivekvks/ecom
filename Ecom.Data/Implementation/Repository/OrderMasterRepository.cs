using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class OrderMasterRepository : IOrderMasterRepository
    {
        private readonly IRepository _repository;
        public OrderMasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public int Add(OrderMasterAddRequest request)
        {
            string orderProductDetailsJsonString = Newtonsoft.Json.JsonConvert.SerializeObject(request.OrderProductDetails);
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("UserId", request.UserId);
            parameters.Add("OrderProductDetailsJsonString", orderProductDetailsJsonString);
            return _repository.ExecResult<int>(StoredProcedure.ORDERMASTER_ADD, parameters).FirstOrDefault();
        }
    }
}
