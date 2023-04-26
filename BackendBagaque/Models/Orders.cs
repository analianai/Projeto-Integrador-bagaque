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
        public int IdOrders { get; set; }
        public DateTime Dater { get; set; }
        public DateTime FinalDateDelivery { get; set; }
        public int CodeDelivery { get; set; }
        public string StatusOrder { get; set; }
        public string TypePayment { get; set; }
        public string StatusPayment { get; set; }
        
        public int IdUser { get; set; }
    }
    public class ProductOrder 
    {
        [Key]
        public int IdProductOrder { get; set; }

        [Required]
        public int IdProduct { get; set; }
        public Products? Product { get; set; }

        [Required]
        public int IdOrders { get; set; }
        public Orders? Order { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
