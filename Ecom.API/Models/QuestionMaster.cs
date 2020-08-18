using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class QuestionMaster
    {
       

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductListingId { get; set; }
        public string QuestionText { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public int BuyerTypeId { get; set; }

    }
}
