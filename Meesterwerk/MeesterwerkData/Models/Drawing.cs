using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MeesterwerkData.Models
{
    public class Drawing
    {
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Name { get; set; }

        public string Rev { get; set; }

        public int Line { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerUnit { get; set; }

        public bool Printed { get; set; }
    }
}
