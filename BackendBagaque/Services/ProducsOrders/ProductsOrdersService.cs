using BackendBagaque.Models;
using BackendBagaque.Data;


namespace BackendBagaque.Services.ProducsOrders
{

    public class ProductsOrdersService
    {
        private readonly BagaqueDBContext context;

        public ProductsOrdersService(BagaqueDBContext context)
        {
            this.context = context;
        }
       
        public List<ProductsOrders> GetProductsOrdersAll()
        {
            return context.ProductsOrders.ToList();
        }

        //Este END POINT Seleciona por id a tabela Order
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

        //Este END POINT Atualiza os dados para Tabela Order por id do Usuario global
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
