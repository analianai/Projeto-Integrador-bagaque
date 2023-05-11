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
        public string? StatusOrder { get; set; }
        public string? TypePayment { get; set; }
        public string? StatusPayment { get; set; }
        [Required]
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public Users? User { get; set; }
    }
    public class ProductsOrders
    {
        [Key]
        public int IdProductsorders { get; set; }

        [Required]
        public int IdProducts { get; set; }
        [ForeignKey("IdProducts")]
        public Products? Products { get; set; }

        [Required]
        public int IdOrders { get; set; }
        [ForeignKey("IdOrders")]
        public Orders? Orders { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
