using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBagaque.Models
{
    public class ProductOrder : Orders
    {
        public int IdProduct { get; set; }
        public int IdOrder { get; set; }
        public int QuantityProductOrder { get; set; }
    }
}