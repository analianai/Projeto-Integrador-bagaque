using System.ComponentModel.DataAnnotations;

namespace BackendBagaque.Models
{
    public class Users
    {
        [Key]
        public int IdUsers { get; set; }
        public string Names { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public string PasswordLogin { get; set; }
        public string EmailLogin { get; set; }
        public string PostalCode{ get; set; }
        public string NumberAddress { get; set; }
        public int TypeUser { get; set; }
    }
}
