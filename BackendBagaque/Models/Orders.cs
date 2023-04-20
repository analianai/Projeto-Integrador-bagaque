using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBagaque.Models
{
    public class Orders
    {
        [Key]
        public int IdOrder { get; set; }
        public DateTime Dater { get; set; }
        public DateTime FinalDateDelivery { get; set; }
        public int CodeDelivery { get; set; }
        public string StatusOrder { get; set; }
        public string TypePayment { get; set; }
        public string StatusPayment { get; set; }      
    }
    public class ProductOrder
    {

        [Required]
        public int IdProduct { get; set; }
        [Required]
        public int IdOrders { get; set; }
        public int Quantity { get; set; }
    }
}
