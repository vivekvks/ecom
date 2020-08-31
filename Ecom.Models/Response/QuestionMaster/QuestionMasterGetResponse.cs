using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Response
{
    public class QuestionMasterGetResponse
    {
        public int Id { get; set; }
        public int ProductListingId { get; set; }
        public string QuestionText { get; set; }
        public DateTime Date { get; set; }
        public int BuyerTypeId { get; set; }
        public int UserId { get; set; }
    }
}
