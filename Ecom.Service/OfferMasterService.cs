using Ecom.Data.Interface;
using Ecom.Models.Request;
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
        public int Add(OfferMasterAddRequest request)
        {
            return _offerMasterRepository.Add(request);
        }
        public int Update(int id, OfferMasterUpdateRequest request)
        {
            return _offerMasterRepository.Update(id, request);
        }
        public bool Delete(int id)
        {
            return _offerMasterRepository.Delete(id);
        }
    }
}
