using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface IMasterService
    {
        List<CountryLookupResponse> CountryLookup();
        string AttributeAndVarianceLookup();
        List<TaxLookupResponse> TaxLookup();
    }
}
