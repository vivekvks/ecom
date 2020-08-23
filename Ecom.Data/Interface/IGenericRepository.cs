using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Interface
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(bool isActive);
        Task DeleteRowAsync(int id);
        Task<T> GetAsync(int id);
        Task<int> SaveRangeAsync(IEnumerable<T> list);
        Task UpdateAsync(T t);
        Task<int> InsertAsync(T t);
        void Exec<RequestModel>(string funcName, RequestModel requestModel);
        List<T> ExecResult<RequestModel>(string spName, RequestModel requestModel);
    }
}
