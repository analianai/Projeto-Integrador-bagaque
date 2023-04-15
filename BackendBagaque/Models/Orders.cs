<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBagaque.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime FinalDateDelivery { get; set; }
        public int CodeDelivery { get; set; }
        public string Status{ get; set; }
        public string TypePayment { get; set; }
        public string StatusPayment { get; set; }
 
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendBagaque.Models
{
    public class Orders
    {
        public int IdOrder { get; set; }
        public int DateOrder { get; set; }
        public int FinalDateDeliveryOrder { get; set; }
        public int CodeDeliveryOrder { get; set; }
        public string StatusOrder { get; set; }
        public string TypePaymentOrder { get; set; }
        public string StatusPaymentOrder { get; set; }
 
    }
}
>>>>>>> main
