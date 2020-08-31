using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface IQuestionMasterRepository
    {
        QuestionMasterGetResponse Get(int id);
        QuestionMasterAddResponse Add(QuestionMasterAddRequest request);
        QuestionMasterUpdateResponse Update(QuestionMasterUpdateRequest request);
        void Delete(int id, int userId);
        List<QuestionMasterListResponse> List(int productListingId);
    }
}
