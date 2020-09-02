using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class ReviewMasterRepository : IReviewMasterRepository
    {
        private readonly IRepository _repository;
        public ReviewMasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public List<ReviewMasterGetResponse> List(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("ProductListingId", id);
            return _repository.ExecResult<ReviewMasterGetResponse>(StoredProcedure.REVIEWMASTER_LIST, parameters);
        }

        public ReviewMasterAddResponse Add(ReviewMasterAddRequest request)
        {
            return _repository.ExecResult<ReviewMasterAddResponse>(StoredProcedure.REVIEWMASTER_ADD, _repository.GetParameters(request)).FirstOrDefault();
        }

        public void Update(ReviewMasterUpdateRequest request)
        {
            var parameters = _repository.GetParameters(request);
            _repository.ExecResult<int>(StoredProcedure.REVIEWMASTER_UPDATE, parameters).FirstOrDefault();
        }

        public void Delete(int id, int userId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            parameters.Add("UserId", userId);
            _repository.ExecResult<int>(StoredProcedure.REVIEWMASTER_DELETE, parameters);
        }

        public void SaveReaction(ReviewReactionRequest request)
        {
            var parameters = _repository.GetParameters(request);
            _repository.ExecResult<int>(StoredProcedure.REVIEWREACTION_SAVE, parameters).FirstOrDefault();
        }
    }
}
