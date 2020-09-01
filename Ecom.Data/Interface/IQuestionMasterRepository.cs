using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;

namespace Ecom.Data.Interface
{
    public interface IQuestionMasterRepository
    {
        string Get(int id);
        QuestionMasterAddResponse Add(QuestionMasterAddRequest request);
        QuestionMasterUpdateResponse Update(QuestionMasterUpdateRequest request);
        void Delete(int id, int userId);
        string List(int productListingId);
    }
}
