using Dapper;
using Ecom.Data.Interface;
using Ecom.Models.Constants;
using Ecom.Models.Request;
using Ecom.Models.Response;
using System.Linq;

namespace Ecom.Data.Implementation.Repository
{
    public class CategoryMasterRepository : ICategoryMasterRepository
    {
        private readonly IRepository _repository;
        public CategoryMasterRepository(IRepository repository)
        {
            _repository = repository;
        }
        public CategoryMasterGetResponse Get(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            return _repository.ExecResult<CategoryMasterGetResponse>(StoredProcedure.CATEGORYMASTER_GET, parameters).FirstOrDefault();
        }

        public string GetHierarchyJson(int id, bool isRoot)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            parameters.Add("IsRoot", isRoot ? 1 : 2);
            return _repository.ExecResult<string>("CategoryMaster_GetHierarchyJson", parameters).FirstOrDefault();
        }

        public int Add(CategoryMasterAddRequest request)
        {
            return _repository.ExecResult<int>(StoredProcedure.CATEGORYMASTER_ADD, _repository.GetParameters(request)).FirstOrDefault();
        }

        public int Update(int id, CategoryMasterUpdateRequest request)
        {
            var parameters = _repository.GetParameters(request);
            parameters.Add("Id", id);
            return _repository.ExecResult<int>(StoredProcedure.CATEGORYMASTER_UPDATE, parameters).FirstOrDefault();
        }

        public bool Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("Id", id);
            _repository.ExecResult<int>(StoredProcedure.CATEGORYMASTER_DELETE, parameters);
            return true;
        }
    }
}
