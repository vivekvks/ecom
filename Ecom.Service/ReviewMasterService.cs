using Ecom.Data.Interface;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service
{
    public class ReviewMasterService : IReviewMasterService
    {
        private readonly IReviewMasterRepository _reviewMasterRepository;
        public ReviewMasterService(IReviewMasterRepository reviewMasterRepository)
        {
            _reviewMasterRepository = reviewMasterRepository;
        }

        public List<ReviewMasterGetResponse> List(int productListingId)
        {
            return _reviewMasterRepository.List(productListingId);
        }

        public ReviewMasterAddResponse Add(ReviewMasterAddRequest request)
        {
            return _reviewMasterRepository.Add(request);
        }

        public void Update(ReviewMasterUpdateRequest request)
        {
            _reviewMasterRepository.Update(request);
        }

        public void Delete(int id, int userId)
        {
            _reviewMasterRepository.Delete(id, userId);
        }

        public void SaveReaction(ReviewReactionRequest request)
        {
            _reviewMasterRepository.SaveReaction(request);
        }
    }
}
