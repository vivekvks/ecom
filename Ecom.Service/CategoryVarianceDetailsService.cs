﻿using AutoWrapper.Wrappers;
using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Service.Interface;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;

namespace Ecom.Service
{
    public class CategoryVarianceDetailsService : ICategoryVarianceDetailsService
    {
        private readonly ICategoryVarianceDetailsRepository _categoryVarianceDetailsRepository;
        public CategoryVarianceDetailsService(ICategoryVarianceDetailsRepository categoryVarianceDetailsRepository)
        {
            _categoryVarianceDetailsRepository = categoryVarianceDetailsRepository;
        }

        public List<int> AddRange(List<CategoryVarianceDetailsAddRequest> requests)
        {
            if (requests.Any(x => !x.VarianceMasterId.HasValue && string.IsNullOrEmpty(x.VarianceMasterName)))
            {
                throw new ApiException("Variance details can not be null.");
            }
            return _categoryVarianceDetailsRepository.AddRange(requests);
        }
    }
}