using BackendBagaque.Data;
using Microsoft.EntityFrameworkCore;

namespace BackendBagaque.Services.Orders
{
    public class OrdersService
    {
        private readonly BagaqueDBContext context;

        public OrdersService(BagaqueDBContext context)
        {
            this.context = context;
        }

        /*                  SERVICES ORDERS                     */ 
        //Este END POINT Seleciona toda a tabela Order
        public List<Models.Orders> GetAll()
        {
            return context.Orders.ToList();
        }

        //Este END POINT Seleciona por id a tabela Order
        public Models.Orders? GetOne(int IdOrders)
        {
            var orders = context.Orders.Find(IdOrders);
            return orders;
        }

        //Este END POINT Cria dados para Tabela Order por id do Usuario Global
        public Models.Orders CreateOrdersBy(Models.Orders orders, int IdUsers)
        {
            var user = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
            if (user == null)
            {
                throw new Exception("Tipo de pagamento invalido");
            }
            else
            {
                context.Orders.Add(orders);
                context.SaveChanges();
                return orders;
            }
        }

        //Este END POINT Cria dados para Tabela Order por id do Usuario ADm
        public Models.Orders CreateOrdersByAdm(Models.Orders orders, int IdUsers)
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

        //Este END POINT Atualiza os dados para Tabela Order por id do Usuario global
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

        //Este END POINT Atualiza os dados para Tabela Order por id do Usuario Adm
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

        //Este END POINT Deleta os dados para Tabela Order por id do Usuario global
        public void DeleteOrderByAdm(int IdOrders,int IdUsers)
        {
            var use = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
            if (use != null && use.TypeUser == 2)
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
            else
            {
                throw new Exception("Liberação só para usuario admin");
            }
        }

        /*                  SERVICES ORDERS/  PRODUCORDER       */
        public List<Models.ProductOrder> GetProductOrderAll()
        {
            return context.ProductOrder.ToList();
        }
        
    }
}
