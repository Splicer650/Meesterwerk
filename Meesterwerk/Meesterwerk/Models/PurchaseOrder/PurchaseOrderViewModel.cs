using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meesterwerk.Models.PurchaseOrder
{
    public class PurchaseOrderViewModel
    {
        public IEnumerable<PurchaseOrderModel> PurchaseOrders { get; set; }
    }
}
