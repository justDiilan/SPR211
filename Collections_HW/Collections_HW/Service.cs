using InternetMagazine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_HW
{
    internal class Service
    {
        private readonly DBContext dbContext;

        public Service(DBContext context)
        {
            dbContext = context;
        }

        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = dbContext.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.CategoryId = product.CategoryId;
                existingProduct.ManufacturerId = product.ManufacturerId;
                existingProduct.Name = product.Name;
            }
        }

        public void DeleteProduct(int productId)
        {
            var product = dbContext.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                dbContext.Products.Remove(product);
            }
        }

        public Product GetProductById(int productId)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == productId);
        }

        // Дополнительные методы

        public List<Product> SearchProducts(string keyword)
        {
            return dbContext.Products.Where(p => p.Name.Contains(keyword)).ToList();
        }

        public List<Product> SortProductsByName()
        {
            return dbContext.Products.OrderBy(p => p.Name).ToList();
        }
    }
}
