﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Egret.Attributes;

namespace Egret.ViewModels
{
    public class ConsumptionEventSearchModel : PagingInfo
    {
        [Display(Name = "Inventory Item Code")]
        public string InventoryItemId { get; set; }

        [UIHint("date")]
        public DateTime? DateCreatedStart { get; set; }

        [UIHint("date")]
        public DateTime? DateCreatedEnd { get; set; }

        [Display(Name = "Consumed By")]
        public string ConsumedBy { get; set; }

        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }

        public int ResultsPerPage { get; set; }
    }
}
