using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Interface
{
    public interface IProductListingRepository
    {
        string Get(string listingText);
    }
}
