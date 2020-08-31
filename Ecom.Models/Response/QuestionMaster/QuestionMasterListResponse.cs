using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Response
{
    public class QuestionMasterListResponse : QuestionMasterGetResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
