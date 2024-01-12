using InternetMagazine;

namespace Collections_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DBContext();

            dbContext.Categories.Add(new Category { Id = 1, Name = "Electronics" });
            dbContext.Manufacturers.Add(new Manufacturer { Id = 1, Name = "Manufacturer A" });
            dbContext.Products.Add(new Product { Id = 1, CategoryId = 1, ManufacturerId = 1, Name = "Laptop" });
            dbContext.Customers.Add(new Customer { Id = 1, Name = "John Doe", PhoneNumber = "123-456-7890" });

            var service = new Service(dbContext);

            int productId = 1;
            var foundProduct = service.GetProductById(productId);
            if (foundProduct != null)
            {
                Console.WriteLine($"Found product: {foundProduct.Name}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            var sortedProducts = service.SortProductsByName();
            Console.WriteLine("Sorted Products:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"{product.Id} - {product.Name}");
            }

            string keyword = "Laptop";
            var searchResults = service.SearchProducts(keyword);
            Console.WriteLine($"Search results for '{keyword}':");
            foreach (var product in searchResults)
            {
                Console.WriteLine($"{product.Id} - {product.Name}");
            }
        }
    }
}