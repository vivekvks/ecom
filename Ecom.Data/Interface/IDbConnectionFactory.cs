using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Ecom.Data.Interface
{
    public interface IDbConnectionFactory
    {
        void CloseConnection();

        IDbConnection GetConnection { get; }
    }
}
