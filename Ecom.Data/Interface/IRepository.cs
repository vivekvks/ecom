﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Interface
{
    public interface IRepository
    {
        DynamicParameters GetBaseParameters<T>(T request);
        List<T> ExecResult<T>(string spName, DynamicParameters parameters);
        Task<List<T>> ExecResultAsync<T>(string spName, DynamicParameters parameters);
    }
}
