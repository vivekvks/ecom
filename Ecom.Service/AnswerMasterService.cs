﻿using Ecom.Data.Interface;
using Ecom.Models.Enums;
using Ecom.Models.Request;
using Ecom.Models.Response;
using Ecom.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Service
{
    public class AnswerMasterService : IAnswerMasterService
    {
        private readonly IAnswerMasterRepository _answerMasterRepository;
        public AnswerMasterService(IAnswerMasterRepository AnswerMasterRepository)
        {
            _answerMasterRepository = AnswerMasterRepository;
        }

        public AnswerMasterGetResponse Get(int id)
        {
            return _answerMasterRepository.Get(id);
        }

        public AnswerMasterAddResponse Add(AnswerMasterAddRequest request)
        {
            return _answerMasterRepository.Add(request);
        }

        public AnswerMasterUpdateResponse Update(AnswerMasterUpdateRequest request)
        {
            return _answerMasterRepository.Update(request);
        }

        public void Delete(int id, int userId)
        {
            _answerMasterRepository.Delete(id, userId);
        }
        
        public AnswerReactionSaveResponse SaveReaction(int userId, int answerId, AnswerReactionType type)
        {
            return _answerMasterRepository.SaveReaction(userId, answerId, type);
        }
    }
}
