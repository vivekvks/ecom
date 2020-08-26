using System;

namespace Ecom.API.Models
{
    public partial class ReviewMaster
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int ProductListingId { get; set; }
        public int BuyerTypeId { get; set; }
        public int? UpVote { get; set; }
        public int? DownVote { get; set; }
        public int? ReportAbuse { get; set; }
        public int? Ratting { get; set; }

    }
}
