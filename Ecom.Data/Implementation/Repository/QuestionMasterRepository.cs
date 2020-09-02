using Dapper;
using Ecom.Data.Interface;
using Ecom.Data.Models;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class QuestionMasterRepository : IQuestionMasterRepository
    {
        private readonly IRepository _repository;
        public QuestionMasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public string Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            return _repository.ExecResult<BaseResult>(StoredProcedure.QUESTIONMASTER_GET, parameters).FirstOrDefault()?.JsonData;
        }

        public QuestionMasterAddResponse Add(QuestionMasterAddRequest request)
        {
            return _repository.ExecResult<QuestionMasterAddResponse>(StoredProcedure.QUESTIONMASTER_ADD, _repository.GetParameters(request)).FirstOrDefault();
        }

        public QuestionMasterUpdateResponse Update(QuestionMasterUpdateRequest request)
        {
            var parameters = _repository.GetParameters(request);
            return _repository.ExecResult<QuestionMasterUpdateResponse>(StoredProcedure.QUESTIONMASTER_UPDATE, parameters).FirstOrDefault();
        }

        public void Delete(int id, int userId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            parameters.Add("UserId", userId);
            _repository.ExecResult<int>(StoredProcedure.QUESTIONMASTER_DELETE, parameters);
        }

        public string List(int productListingId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ProductListingId", productListingId);
            return _repository.ExecResult<BaseResult>(StoredProcedure.QUESTIONMASTER_LIST, parameters).FirstOrDefault()?.JsonData;
        }
    }
}
