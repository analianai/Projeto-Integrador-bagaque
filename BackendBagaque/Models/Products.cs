using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBagaque.Models
{
    public class Products
    {
        [Key]
        public int IdProducts { get; set; }

        public string Title { get; set; }

        public string Descriptions { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Images { get; set; }
        
        public string Tags { get; set; }
    }
}
