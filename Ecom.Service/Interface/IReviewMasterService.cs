using Ecom.Models.Request;
using Ecom.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service.Interface
{
    public interface IReviewMasterService
    {
        List<ReviewMasterGetResponse> List(int productListingId);
        ReviewMasterAddResponse Add(ReviewMasterAddRequest request);
        void Update(ReviewMasterUpdateRequest request);
        void Delete(int id, int userId);
        void SaveReaction(ReviewReactionRequest request);
    }
}
