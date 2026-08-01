using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gün8
{
    public class Product
    {
        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;

            Console.WriteLine("Product created: " + Name + ", Price: " + Price + ", Stock: " + Stock);
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
    public class Customer
    {
        public Customer(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Console.WriteLine("Customer created: " + Name + " " + Surname + ", Age: " + Age);
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    public class Order
    {
        public Order(int orderNumber, int quantity)
        {
            OrderNumber = orderNumber;
            Quantity = quantity;
            Console.WriteLine("Order created: Order Number: " + OrderNumber + ", Quantity: " + Quantity);
        }
        public int OrderNumber { get; set; }
        public int Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product("HP", 1500, 10);
            Customer customer = new Customer("John", "Doe", 30);
            Order order = new Order(1, 2);
            Console.ReadLine();
        }
    }
}
