namespace BackendBagaque.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Phone { get; set; }
        public string SenhaLogin { get; set; }
        public string EmailLogin { get; set; }
        public int Type { get; set; }
        public string PostalCode{ get; set; }
        public string Number { get; set; }
    }
}
