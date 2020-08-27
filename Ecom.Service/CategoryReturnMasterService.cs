using Ecom.Data.Interface;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Service
{
    public class CategoryReturnMasterService : ICategoryReturnMasterService
    {
        private readonly ICategoryReturnMasterRepository _categoryReturnMasterRepository;
        public CategoryReturnMasterService(ICategoryReturnMasterRepository categoryReturnMasterRepository)
        {
            _categoryReturnMasterRepository = categoryReturnMasterRepository;
        }
        public List<CategoryReturnMasterGetResponse> List()
        {
            return _categoryReturnMasterRepository.List();
        }
    }
}
