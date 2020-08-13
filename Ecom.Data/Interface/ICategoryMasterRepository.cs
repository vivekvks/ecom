using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Data.Interface
{
    public interface ICategoryMasterRepository
    {
        Task<string> Get();
    }
}
