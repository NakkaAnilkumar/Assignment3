using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
   

    // Create an enum for PaymentMode
    enum PaymentMode
    {
        CreditCard,
        DebitCard,
        PayPal,
        Cash
    }
  

    class Program
    {
        static void Main()
        {
            // Example usage:
            Customer customer = new Customer
            {
                Custid = 1,
                Custname = "John Doe"
            };

            Products product1 = new Products
            {
                ProductId = 101,
                Prodname = "Product A",
                Qty = 10,
                Price = 20
            };

            Products product2 = new Products
            {
                ProductId = 102,
                Prodname = "Product B",
                Qty = 15,
                Price = 30
            };

            Order order = new Order();
            order.OrderedProducts.Add(product1);
            order.OrderedProducts.Add(product2);
            order.PaymentMode = PaymentMode.CreditCard; // Set the payment mode here

            Console.WriteLine("Order Details:");
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine($"Order Date: {order.OrderDate}");
            Console.WriteLine($"Customer ID: {customer.Custid}");
            Console.WriteLine($"Customer Name: {customer.Custname}");
            Console.WriteLine("Ordered Products:");

            foreach (var product in order.OrderedProducts)
            {
                Console.WriteLine($"Product ID: {product.ProductId}");
                Console.WriteLine($"Product Name: {product.Prodname}");
                Console.WriteLine($"Quantity: {product.Qty}");
                Console.WriteLine($"Price: ${product.Price}");
            }

            Console.WriteLine($"Payment Mode: {order.PaymentMode}");
            Console.WriteLine("Order booked successfully!");
            Console.ReadLine();
        }
    }


    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //}
}

