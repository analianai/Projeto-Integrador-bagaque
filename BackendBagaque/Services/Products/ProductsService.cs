using BackendBagaque.Data;
using BackendBagaque.Models;

namespace BackendBagaque.Services.Products
{
    public class ProductsService
    {
        private readonly BagaqueDBContext context;

        public string IdProducts { get; private set; }

        public ProductsService(BagaqueDBContext context)
        {
            this.context = context;
        }

        public List<Models.Products> GetAll()
        {
            return context.Products.ToList();
        }

        public Models.Products? GetOne(int IdProducts)
        {
            var products = context.Products.Find(IdProducts);
            return products;
        }

        public Models.Products CreateProductByAdm(Models.Products products, int IdUsers)
        {
            var user = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
      
            if (user == null || user.TypeUser != 2)
            {
                throw new Exception("Somente adminstrador do sistema, podem cadastrar produtos!");
            }
            else
            {
                var product = context.Products.FirstOrDefault(p => p.Title == products.Title);

                if (product == null)
                {
                    context.Products.Add(products);
                    context.SaveChanges();
                    return products;
                }
                else
                {
                    throw new Exception("Já existe um produto cadastrado com esse nome!");
                }
            }
        }

        public void UpdateProductByAdmin(int IdProducts, Models.Products products, int IdUsers)
        {
            var user = context.Users.FirstOrDefault(u => u.IdUsers == IdUsers);
            if (user == null || user.TypeUser == 2)
            {
                var productsToUpdate = context.Products.Find(IdProducts);
                if (productsToUpdate != null)
                {
                    productsToUpdate.Title = products.Title;
                    productsToUpdate.Descriptions = products.Descriptions;
                    productsToUpdate.Category = products.Category;
                    productsToUpdate.Quantity = products.Quantity;
                    productsToUpdate.Price = products.Price;
                    productsToUpdate.Images = products.Images;
                    productsToUpdate.Tags = products.Tags;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Produto não encontrado para o ID " + IdProducts);
                }
            }
            else
            {
                throw new Exception("Somente usuário admin pode Atualizar Produto!" );
            }
        }        
        
        public void DeleteProductByAdmin(int IdProducts, int IdUsers)
        {
            var user = context.Users.FirstOrDefault(I => I.IdUsers == IdUsers);
            if (user != null && user.TypeUser == 2)
            {
                var productsToRemove = context.Products.Find(IdProducts);
                if (productsToRemove != null)
                {
                    context.Products.Remove(productsToRemove);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Produto não encontrado para o id " + IdProducts);
                }
            }
            else
            {
                throw new Exception("Somente usuário admin pode Deletar Produto " + IdUsers);
            }
        }
    }
}
