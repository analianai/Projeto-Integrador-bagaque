using Microsoft.Extensions.Primitives;
using static System.Net.Mime.MediaTypeNames;

namespace BackendBagaque.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Descriptions { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public string Images { get; set; }
        
        public string Tags { get; set; }
    }
}
