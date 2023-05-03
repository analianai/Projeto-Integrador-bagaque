using BackendBagaque.Data;

namespace BackendBagaque.Services.Orders
{
    public class OrdersService
    {
        private readonly BagaqueDBContext context;

        public OrdersService (BagaqueDBContext context)
        {
            this.context = context;
        }

        public List<Models.Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        public Models.Orders? GetOne(int IdOrders)
        {
            var orders = context.Orders.Find(IdOrders);
            return orders;
        }

 
        public Models.Orders CreateOrdersByAdm(Models.Orders orders,int IdUsers)
        {
           var user = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
            if (user == null || user.TypeUser != 2)
            {
                throw new Exception("Liberação só para usuario admin");

            }
            else
            {
                context.Orders.Add(orders);
                context.SaveChanges();
                return orders;
            }
        }



        public void UpdateOrdersBy(int IdOrders, Models.Orders orders)
        {
            var ordersToUpdate = context.Orders.Find(IdOrders);
            if (ordersToUpdate != null)
            {
                ordersToUpdate.TypePayment = orders.TypePayment;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Pedido não encontrado para o ID " + IdOrders);
            }
        }


        public void UpdateOrdersByAdmin(int IdOrders, Models.Orders orders, int IdUsers)
        { 
            var user = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
            if (user == null || user.TypeUser != 2)
            {
                throw new Exception("Liberação só para usuario admin");
            }
            else
            {
                var ordersToUpdate = context.Orders.Find(IdOrders);
                if (ordersToUpdate != null)
                {
                    ordersToUpdate.FinalDateDelivery = orders.FinalDateDelivery;
                    ordersToUpdate.CodeDelivery = orders.CodeDelivery;
                    ordersToUpdate.StatusOrder = orders.StatusOrder;
                    ordersToUpdate.StatusPayment = orders.StatusPayment;
                    ordersToUpdate.IdUser = orders.IdUser;

                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Pedido não encontrado para o ID " + IdOrders);
                }
            }

        }

        public void Delete(int IdOrders)
        {
            var ordersToRemove = context.Orders.Find(IdOrders);
            if (ordersToRemove != null)
            {
                context.Orders.Remove(ordersToRemove);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Pedido não encontrado para o id " + IdOrders);
            }
        }
    }
}
