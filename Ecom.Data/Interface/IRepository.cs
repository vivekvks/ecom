using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecom.Data.Interface
{
    public interface IRepository
    {
        DynamicParameters GetJsonParameter<T>(T request);
        DynamicParameters GetParameters<T>(T parametersModel);
        List<T> ExecResult<T>(string spName, DynamicParameters parameters);
        Task<List<T>> ExecResultAsync<T>(string spName, DynamicParameters parameters);
        Tuple<List<T1>, List<T2>> ExecResult<T1, T2>(string spName, DynamicParameters parameters);
    }
}
