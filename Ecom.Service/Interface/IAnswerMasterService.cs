using Ecom.Models.Enums;
using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Service.Interface
{
    public interface IAnswerMasterService
    {
        AnswerMasterGetResponse Get(int id);
        AnswerMasterAddResponse Add(AnswerMasterAddRequest request);
        AnswerMasterUpdateResponse Update(AnswerMasterUpdateRequest request);
        void Delete(int id, int userId);
        AnswerReactionSaveResponse SaveReaction(AnswerReactionRequest request);
    }
}
