using System;
using System.Collections.Generic;
using System.Text;

namespace MeesterwerkData.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }

        public string OrderNumber { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Drawing> Drawings { get; set; }
    }
}
