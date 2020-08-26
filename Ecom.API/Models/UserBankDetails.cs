using System;

namespace Ecom.API.Models
{
    public partial class UserBankDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string Ifsc { get; set; }
        public string BankName { get; set; }
        public int CityId { get; set; }
        public string Branch { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
