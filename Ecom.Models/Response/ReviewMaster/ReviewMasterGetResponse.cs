using System;

namespace Ecom.Models.Response
{
    public class ReviewMasterGetResponse
    {
        public int Id { get; set; }
        public int ProductListingId { get; set; }
        public string ReviewText { get; set; }
        public DateTime Date { get; set; }
        public int BuyerTypeId { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public int ReportAbuse { get; set; }
        public int Rating { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public int UserId { get; set; }
    }
}
