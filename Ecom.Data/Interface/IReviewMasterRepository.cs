using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface IReviewMasterRepository
    {
        List<ReviewMasterGetResponse> List(int productListingId);
        ReviewMasterAddResponse Add(ReviewMasterAddRequest request);
        void Update(ReviewMasterUpdateRequest request);
        void Delete(int id, int userId);
        void SaveReaction(ReviewReactionRequest request);
    }
}
