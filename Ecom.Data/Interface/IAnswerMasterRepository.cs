﻿using Ecom.Models.Enums;
using Ecom.Models.Request;
using Ecom.Models.Response;

namespace Ecom.Data.Interface
{
    public interface IAnswerMasterRepository
    {
        AnswerMasterGetResponse Get(int id);
        AnswerMasterAddResponse Add(AnswerMasterAddRequest request);
        AnswerMasterUpdateResponse Update(AnswerMasterUpdateRequest request);
        void Delete(int id, int userId);
        AnswerReactionSaveResponse SaveReaction(int userId, int answerId, AnswerReactionType type);
    }
}
