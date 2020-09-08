using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface IOfferMasterService
    {
        List<OfferMasterGetResponse> List();
        OfferMasterGetResponse Get(int id);
    }
}
