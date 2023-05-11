using BackendBagaque.Models;
using BackendBagaque.Data;

namespace BackendBagaque.Services.Orders
{
    public class OrdersService
    {
        private readonly BagaqueDBContext context;

        public OrdersService(BagaqueDBContext context)
        {
            this.context = context;
        }

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
            if (user != null)
            {
                context.Orders.Add(orders);
                context.SaveChanges();
                return orders;
            }
            else
            {
                throw new Exception("Liberação só para usuario admin");
            }
        }

        //Este END POINT Cria dados para Tabela Order por id do Usuario ADm
        public Models.Orders CreateOrdersByAdm(Models.Orders orders, int IdUsers)
        {
            var user = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
            if ( user != null && user.TypeUser == 2)
            {
                context.Orders.Add(orders);
                context.SaveChanges();
                return orders;
            }
            else
            {
                throw new Exception("Liberação só para usuario admin");
            }
        }

        //Este END POINT Atualiza os dados para Tabela Order por id do Usuario global
        public void UpdateOrdersBy(int IdOrders, Models.Orders orders, int IdUsers)
        {
            var owner = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
            if (owner == null)
            {
                throw new Exception($"Não foi encontrado Usuário para esse ID: {IdUsers}");
            }
            var ordersToUpdate = context.Orders.Find(IdOrders);
            if (ordersToUpdate != null)
            {
                ordersToUpdate.TypePayment = orders.TypePayment;
                context.SaveChanges();
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
                    ordersToUpdate.TypePayment = orders.TypePayment;
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
        public void DeleteOrderByAdm(int IdOrders, int IdUsers)
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

        // PRODUCTSORDERS
        //Este END POINT Seleciona toda a tabela ProductsOrders
        public List<ProductsOrders> GetProductsOrdersAll()
        {
            return context.ProductsOrders.ToList();
        }

        //Este END POINT Seleciona por id a tabela ProductsOrders
        public ProductsOrders GetOneProductsOrders(int IdProductsOrders)
        {
            var productsorders = context.ProductsOrders.Find(IdProductsOrders);
            return productsorders;
        }

        //Este END POINT Cria dados para Tabela ProductOrder por id do Usuario Global

        public Models.ProductsOrders CreateProductsOrdersBy(Models.ProductsOrders productsorders)
        {
            context.ProductsOrders.Add(productsorders);
            context.SaveChanges();
            return productsorders;
        }

        //Este END POINT Atualiza os dados para Tabela ProductOrder por id do Usuario global
        public void UpdateProductOrdersBy(Models.ProductsOrders productsorders, int IdProductsOrders)
        {
            var owner = context.ProductsOrders.FirstOrDefault(po => po.IdProductsorders == IdProductsOrders);
            if (owner == null)
            {
                throw new Exception($"Não foi encontrado Pedido para esse ID: {IdProductsOrders}");
            }
            var productsordersToUpdate = context.ProductsOrders.Find(IdProductsOrders);
            if (productsordersToUpdate != null)
            {
                productsordersToUpdate.IdProducts = productsorders.IdProducts;
                productsordersToUpdate.IdOrders = productsorders.IdOrders;
                productsordersToUpdate.Quantity = productsorders.Quantity;
                context.SaveChanges();
            }
        }

        //Este END POINT Deleta os dados para Tabela Order por id do Usuario global
        public void DeleteProductOrderBy(int IdProductsOrders)
        {
            var productsordersToRemove = context.Orders.Find(IdProductsOrders);
            if (productsordersToRemove != null)
            {
                context.Orders.Remove(productsordersToRemove);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Pedido/ quantidade não encontrado para o id " + IdProductsOrders);
            }
        }

    }
}