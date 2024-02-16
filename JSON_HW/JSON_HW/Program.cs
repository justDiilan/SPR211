namespace JSON_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Learning\C# OOP Academ\JSON_HW\JSON_HW\customers.json";
            CustomerDatabase database = new CustomerDatabase(filePath);

            // Додати нового клієнта
            Customer newCustomer1 = new Customer
            {
                Id = 1,
                Name = "Felix Felixovich",
                Email = "felix@gmail.com",
                PhoneNumber = "1234567890",
            };
            Customer newCustomer2 = new Customer
            {
                Id = 2,
                Name = "John Afrodit",
                Email = "john@gmail.com",
                PhoneNumber = "0987654321",
            };
            Customer newCustomer3 = new Customer
            {
                Id = 3,
                Name = "Oleksandr Silver",
                Email = "oleksandr@gmail.com",
                PhoneNumber = "1234560987",
            };
            database.AddCustomer(newCustomer1);
            database.AddCustomer(newCustomer2);
            database.AddCustomer(newCustomer3);
            database.SaveChanges();

            // Оновити існуючого клієнта
            Customer existingCustomer = database.GetCustomer(1);
            existingCustomer.PhoneNumber = "098-765-4321";
            database.UpdateCustomer(existingCustomer);
            database.SaveChanges();

            // Отримати всіх клієнтів
            List<Customer> allCustomers = database.GetAllCustomers();
            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}, Phone: {customer.PhoneNumber}");
            }

            // Видалити клієнта
            database.DeleteCustomer(1);
            database.SaveChanges();

            // Отримати всіх клієнтівy
            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}, Phone: {customer.PhoneNumber}");
            }
        }
    }
}