﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Interface
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task DeleteRowAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<int> SaveRangeAsync(IEnumerable<T> list);
        Task UpdateAsync(T t);
        Task InsertAsync(T t);
    }
}
