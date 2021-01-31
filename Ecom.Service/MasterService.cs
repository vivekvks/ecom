using Ecom.Data.Interface;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using System.Collections.Generic;

namespace Ecom.Service
{
    public class MasterService : IMasterService
    {
        private readonly IMasterRepository _masterRepository;
        public MasterService(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }
        public string AttributeAndVarianceLookup()
        {
            return _masterRepository.AttributeAndVarianceLookup();
        }

        public List<CountryLookupResponse> CountryLookup()
        {
            return _masterRepository.CountryLookup();
        }

        public List<TaxLookupResponse> TaxLookup()
        {
            return _masterRepository.TaxLookup();
        }
    }
}
