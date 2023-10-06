using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Create the Order class
    class Order
    {
        private static int OrderIdCounter = 1;

        public int OrderId { get; private set; }
        public DateTime OrderDate { get; set; }
        public List<Products> OrderedProducts { get; set; }
        public PaymentMode PaymentMode { get; set; }

        public Order()
        {
            OrderId = OrderIdCounter++;
            OrderDate = DateTime.Now;
            OrderedProducts = new List<Products>();
        }

        public void BookOrder()
        {
            // Perform order booking logic here
        }
    }
}
