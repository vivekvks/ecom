using Ecom.Data.Interface;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service
{
    public class OfferMasterService : IOfferMasterService
    {
        private readonly IOfferMasterRepository _offerMasterRepository;
        public OfferMasterService(IOfferMasterRepository offerMasterRepository)
        {
            _offerMasterRepository = offerMasterRepository;
        }

        public List<OfferMasterGetResponse> List()
        {
            return _offerMasterRepository.List();
        }
        public OfferMasterGetResponse Get(int id)
        {
            return _offerMasterRepository.Get(id);
        }
    }
}
