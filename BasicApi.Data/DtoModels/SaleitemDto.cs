﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicApi.Data.DtoModels
{
    public class SaleitemDto
    {
        public int Id { get; set; }
        public int? SaleId { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public int? Quantity { get; set; }
    }
}
