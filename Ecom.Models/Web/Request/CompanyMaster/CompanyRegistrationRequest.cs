using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.Models.Web.Request
{
    public class CompanyRegistrationRequest
    {
        public int UserId { get; set; }
        public string BusinessName { get; set; }
        public string GSTNo { get; set; }
        public string PAN { get; set; }
        public string StoreName { get; set; }
        public string BusinessDescription { get; set; }
        public string RegAddLine1 { get; set; }
        public string RegAddLine2 { get; set; }
        public string RegCity { get; set; }
        public string RegDistrict { get; set; }
        public string RegState { get; set; }
        public string RegPincode { get; set; }
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
    }

    public class CompanyRegistrationRequestValidator : AbstractValidator<CompanyRegistrationRequest>
    {
        public CompanyRegistrationRequestValidator()
        {
            RuleFor(x => x.BusinessName).NotEmpty().MaximumLength(80);
            RuleFor(x => x.GSTNo).NotEmpty().MaximumLength(15);
            RuleFor(x => x.PAN).NotEmpty().MaximumLength(10);
            RuleFor(x => x.StoreName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.BusinessDescription).NotEmpty().MaximumLength(1500);
            RuleFor(x => x.RegAddLine1).NotEmpty().MaximumLength(500);
            RuleFor(x => x.RegAddLine2).NotEmpty().MaximumLength(500);
            RuleFor(x => x.RegCity).NotEmpty().MaximumLength(50);
            RuleFor(x => x.RegDistrict).NotEmpty().MaximumLength(50);
            RuleFor(x => x.RegState).NotEmpty().MaximumLength(50);
            RuleFor(x => x.RegPincode).NotEmpty().MaximumLength(10);
            RuleFor(x => x.PickAddLine1).NotEmpty().MaximumLength(500);
            RuleFor(x => x.PickAddLine2).NotEmpty().MaximumLength(500);
            RuleFor(x => x.PickCity).NotEmpty().MaximumLength(50);
            RuleFor(x => x.PickDistrict).NotEmpty().MaximumLength(50);
            RuleFor(x => x.PickState).NotEmpty().MaximumLength(50);
            RuleFor(x => x.PickPincode).NotEmpty().MaximumLength(10);
            RuleFor(x => x.AccountNo).NotEmpty().MaximumLength(20);
            RuleFor(x => x.AccountHolderName).NotEmpty().MaximumLength(250);
            RuleFor(x => x.IFSC).NotEmpty().MaximumLength(15);
            RuleFor(x => x.BankBranch).NotEmpty().MaximumLength(30);
            RuleFor(x => x.BankName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.BankState).NotEmpty().MaximumLength(30);
            RuleFor(x => x.BankCity).NotEmpty().MaximumLength(50);
        }
    }
}
