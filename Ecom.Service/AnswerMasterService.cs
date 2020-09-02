using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;

namespace Ecom.Service
{
    public class AnswerMasterService : IAnswerMasterService
    {
        private readonly IAnswerMasterRepository _answerMasterRepository;
        public AnswerMasterService(IAnswerMasterRepository AnswerMasterRepository)
        {
            _answerMasterRepository = AnswerMasterRepository;
        }

        public AnswerMasterGetResponse Get(int id)
        {
            return _answerMasterRepository.Get(id);
        }

        public AnswerMasterAddResponse Add(AnswerMasterAddRequest request)
        {
            return _answerMasterRepository.Add(request);
        }

        public AnswerMasterUpdateResponse Update(AnswerMasterUpdateRequest request)
        {
            return _answerMasterRepository.Update(request);
        }

        public void Delete(int id, int userId)
        {
            _answerMasterRepository.Delete(id, userId);
        }

        public AnswerReactionSaveResponse SaveReaction(AnswerReactionRequest request)
        {
            return _answerMasterRepository.SaveReaction(request);
        }
    }
}
