﻿using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Interface
{
    public interface IMasterRepository
    {
        string AttributeAndVarianceLookup();
        List<CountryLookupResponse> CountryLookup();
        List<TaxLookupResponse> TaxLookup();
    }
}
