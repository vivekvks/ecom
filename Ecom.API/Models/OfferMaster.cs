﻿using System;

namespace Ecom.API.Models
{
    public partial class OfferMaster
    {
        public int Id { get; set; }
        public int OfferTypeId { get; set; }
        public int ProductId { get; set; }
        public int Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Text { get; set; }
        public double? SharePercentage { get; set; }
        public bool IsActive { get; set; }

    }
}
