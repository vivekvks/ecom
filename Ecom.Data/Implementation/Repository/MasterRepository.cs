using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Constants;
using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class MasterRepository : IMasterRepository
    {
        private readonly IRepository _repository;
        public MasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public string AttributeAndVarianceLookup()
        {
            return _repository.ExecResult<BaseResult>(StoredProcedure.ATTRIBUTEANDVARIANCEVALUE_LOOKUP, null).FirstOrDefault().JsonData;
        }

        public List<CountryLookupResponse> CountryLookup()
        {
            return _repository.ExecResult<CountryLookupResponse>(StoredProcedure.COUNTRY_LOOKUP, null).ToList();
        }

        public List<TaxLookupResponse> TaxLookup()
        {
            return _repository.ExecResult<TaxLookupResponse>(StoredProcedure.TAX_LOOKUP, null).ToList();
        }
    }
}
