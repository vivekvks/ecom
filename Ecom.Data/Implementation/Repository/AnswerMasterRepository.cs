using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Enums;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class AnswerMasterRepository : IAnswerMasterRepository
    {
        private readonly IRepository _repository;
        public AnswerMasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public AnswerMasterGetResponse Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            return _repository.ExecResult<AnswerMasterGetResponse>(StoredProcedure.ANSWERMASTER_GET, parameters).FirstOrDefault();
        }

        public AnswerMasterAddResponse Add(AnswerMasterAddRequest request)
        {
            return _repository.ExecResult<AnswerMasterAddResponse>(StoredProcedure.ANSWERMASTER_ADD, _repository.GetParameters(request)).FirstOrDefault();
        }

        public AnswerMasterUpdateResponse Update(AnswerMasterUpdateRequest request)
        {
            var parameters = _repository.GetParameters(request);
            return _repository.ExecResult<AnswerMasterUpdateResponse>(StoredProcedure.ANSWERMASTER_UPDATE, parameters).FirstOrDefault();
        }

        public void Delete(int id, int userId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            parameters.Add("UserId", userId);
            _repository.ExecResult<int>(StoredProcedure.ANSWERMASTER_DELETE, parameters);
        }

        public AnswerReactionSaveResponse SaveReaction(AnswerReactionRequest request)
        {
            var parameters = _repository.GetParameters(request);
            return _repository.ExecResult<AnswerReactionSaveResponse>(StoredProcedure.ANSWERREACTION_SAVE, parameters).FirstOrDefault();
        }
    }
}
