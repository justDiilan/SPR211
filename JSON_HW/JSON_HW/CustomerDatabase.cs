using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JSON_HW
{
    public class CustomerDatabase
    {
        private List<Customer> customers;
        private string filePath;
        public CustomerDatabase(string filePath)
        {
            this.filePath = filePath;
            if (!File.Exists(filePath)) 
            {
                File.WriteAllText(filePath, "[]");
            }

            string json = File.ReadAllText(filePath);
            customers = JsonSerializer.Deserialize<List<Customer>>(json);
        }

        public void SaveChanges()
        {
            string json = JsonSerializer.Serialize(customers);
            File.WriteAllText(filePath, json);
        }

        public void AddCustomer(Customer customer)
        {
            if (customers.Any(c => c.Id == customer.Id))
            {
                Console.WriteLine($"Customer with identificator {customer.Id}, already exists.");
            }
            else
            {
                customers.Add(customer);
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            int index = customers.FindIndex(c => c.Id == customer.Id);
            if (index != -1)
            {
                customers[index] = customer;
            }
            else
            {
                throw new ArgumentException("Customer not found");
            }
        }

        public void DeleteCustomer(int customerId)
        {
            Customer customer = customers.Find(c => c.Id == customerId);
            if (customer != null)
            {
                customers.Remove(customer);
            }
            else
            {
                throw new ArgumentException("Customer not found");
            }
        }

        public Customer GetCustomer(int customerId)
        {
            return customers.Find(c => c.Id == customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }
    }
}
