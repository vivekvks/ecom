using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;

namespace Ecom.Service
{
    public class QuestionMasterService : IQuestionMasterService
    {
        private readonly IQuestionMasterRepository _questionMasterRepository;
        public QuestionMasterService(IQuestionMasterRepository QuestionMasterRepository)
        {
            _questionMasterRepository = QuestionMasterRepository;
        }

        public string Get(int id)
        {
            return _questionMasterRepository.Get(id);
        }

        public QuestionMasterAddResponse Add(QuestionMasterAddRequest request)
        {
            return _questionMasterRepository.Add(request);
        }

        public QuestionMasterUpdateResponse Update(QuestionMasterUpdateRequest request)
        {
            return _questionMasterRepository.Update(request);
        }

        public void Delete(int id, int userId)
        {
            _questionMasterRepository.Delete(id, userId);
        }

        public string List(int productListingId)
        {
            return _questionMasterRepository.List(productListingId);
        }
    }
}
