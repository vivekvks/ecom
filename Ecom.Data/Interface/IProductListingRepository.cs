﻿using Ecom.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Interface
{
    public interface IProductListingRepository
    {
        List<int> AddRange(List<ProductListingRequest> requests);
    }
}
