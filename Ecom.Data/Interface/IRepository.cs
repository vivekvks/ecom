using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecom.Data.Interface
{
    public interface IRepository
    {
        DynamicParameters GetBaseParameters<T>(T request);
        DynamicParameters GetParameters<T>(T parametersModel);
        List<T> ExecResult<T>(string spName, DynamicParameters parameters);
        Task<List<T>> ExecResultAsync<T>(string spName, DynamicParameters parameters);
    }
}
