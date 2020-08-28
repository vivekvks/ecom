using Ecom.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Data.Implementation.Repository
{
    public class ProductListingRepository : IProductListingRepository
    {
        private readonly IRepository _repository;
        public ProductListingRepository(IRepository repository)
        {
            _repository = repository;
        }
    }
}
