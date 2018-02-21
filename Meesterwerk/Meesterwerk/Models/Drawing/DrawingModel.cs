using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meesterwerk.Models.Drawing
{
    public class DrawingModel
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Rev { get; set; }

        public string Name { get; set; }

        public int Line { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerUnit { get; set; }

        public bool Printed { get; set; }
    }
}
