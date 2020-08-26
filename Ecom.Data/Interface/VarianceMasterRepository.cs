using Ecom.Data.Interface;
using Ecom.Data.Models;

namespace Ecom.Data.Implementation.Repository
{
    public class VarianceMasterRepository : GenericRepository<VarianceMaster>, IVarianceMasterRepository
    {
        public VarianceMasterRepository() : base(nameof(VarianceMaster))
        {

        }
    }
}
