using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Response
{
    public class AnswerMasterGetResponse
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public int ReportAbuse { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
