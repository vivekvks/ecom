using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class AnswerMaster
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public int UpVote { get; set; }
        public int? DownVote { get; set; }
        public int? ReportAbuse { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }

    }
}
