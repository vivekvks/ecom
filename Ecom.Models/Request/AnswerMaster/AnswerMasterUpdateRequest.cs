using FluentValidation;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class AnswerMasterUpdateRequest
    {
        [JsonIgnore]
        public int UserId { get; set; }

        [JsonIgnore]
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public string AnswerText { get; set; }
    }

    public class AnswerMasterUpdateRequestValidator : AbstractValidator<AnswerMasterUpdateRequest>
    {
        public AnswerMasterUpdateRequestValidator()
        {
            RuleFor(x => x.AnswerText).NotEmpty().MaximumLength(1000);
            RuleFor(x => x.QuestionId).NotEmpty();
        }
    }
}
