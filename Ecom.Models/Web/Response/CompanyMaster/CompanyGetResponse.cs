using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Response
{
    public class CompanyGetResponse
    {
        public int UserId { get; set; }
        public string BusinessName { get; set; }
        public string GSTNo { get; set; }
        public string PAN { get; set; }
        public string StoreName { get; set; }
        public string BusinessDescription { get; set; }
        public int RegAddId { get; set; }
        public string RegAddLine1 { get; set; }
        public string RegAddLine2 { get; set; }
        public string RegCity { get; set; }
        public string RegDistrict { get; set; }
        public string RegState { get; set; }
        public string RegPincode { get; set; }
        public int PickAddId { get; set; }
        public string PickAddLine1 { get; set; }
        public string PickAddLine2 { get; set; }
        public string PickCity { get; set; }
        public string PickState { get; set; }
        public string PickDistrict { get; set; }
        public string PickPincode { get; set; }
        public string AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string IFSC { get; set; }
        public string BankName { get; set; }
        public string BankState { get; set; }
        public string BankCity { get; set; }
        public string BankBranch { get; set; }
        public int UserBankDetailId { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
