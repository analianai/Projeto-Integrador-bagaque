using BackendBagaque.Data;
using BackendBagaque.Models;

namespace BackendBagaque.Services.Products
{
    public class ProductsService
    {
        private readonly BagaqueDBContext context;

        public ProductsService (BagaqueDBContext context)
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

        public Models.Products Create(Models.Products products)
        {
            context.Products.Add(products);
            context.SaveChanges();
            return products;
        }
      
        public Models.Products CreateProductByAdm(Models.Products products, int IdUsers)
        {
            var user = context.Users.FirstOrDefault(i => i.IdUsers == IdUsers);
      
            if (user == null || user.TypeUser != 2)
            {
                throw new Exception("Somente adminstrador do sistema, podem cadastrar produtos!");
            }
            else
            {
                var product = context.Products.FirstOrDefault(i => i.Title == products.Title);

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

        public void Update(int IdProducts, Models.Products products)
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

        public void Delete(int IdProducts)
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
    }
}
