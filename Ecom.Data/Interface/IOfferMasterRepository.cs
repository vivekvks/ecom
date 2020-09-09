using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface IOfferMasterRepository
    {
        List<OfferMasterGetResponse> List();
        OfferMasterGetResponse Get(int id);
        int Add(OfferMasterAddRequest request);
        int Update(int id, OfferMasterUpdateRequest request);
        bool Delete(int id);
    }
}
