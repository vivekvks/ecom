using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Interface
{
    public interface IOfferMasterRepository
    {
        List<OfferMasterGetResponse> List();
        OfferMasterGetResponse Get(int id);
    }
}
