﻿using System;
using System.Collections.Generic;

namespace Ecom.API.Models
{
    public partial class BrandMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
