using FluentValidation;
using System.Text.Json.Serialization;

namespace Ecom.Models.Request
{
    public class AnswerMasterAddRequest
    {
        [JsonIgnore]
        public int UserId { get; set; }

        public int QuestionId { get; set; }

        public string AnswerText { get; set; }
    }

    public class AnswerMasterAddRequestValidator : AbstractValidator<AnswerMasterAddRequest>
    {
        public AnswerMasterAddRequestValidator()
        {
            RuleFor(x => x.AnswerText).NotEmpty().MaximumLength(1000);
            RuleFor(x => x.QuestionId).NotEmpty();
        }
    }
}
