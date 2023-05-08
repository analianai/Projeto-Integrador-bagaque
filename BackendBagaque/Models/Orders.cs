using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public Users? User { get; set; }
    }
    public class ProductOrder 
    {
        [Key]
        public int IdProductOrder { get; set; }

        [Required]
        public int IdProduct { get; set; }
        [ForeignKey("IdProduct")]
        public Products? Product { get; set; }

        [Required]
        public int IdOrder { get; set; }
        [ForeignKey("IdOrder")]
        public Orders? Order { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
