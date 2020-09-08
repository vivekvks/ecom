using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class OfferMasterRepository : IOfferMasterRepository
    {
        private readonly IRepository _repository;
        public OfferMasterRepository(IRepository repository)
        {
            _repository = repository;
        }

        public List<OfferMasterGetResponse> List()
        {
            return _repository.ExecResult<OfferMasterGetResponse>(StoredProcedure.OFFERMASTER_LIST, null).ToList();
        }

        public OfferMasterGetResponse Get(int id)
        {
            return _repository.ExecResult<OfferMasterGetResponse>(StoredProcedure.OFFERMASTER_GET, null).FirstOrDefault();
        }
    }
}
