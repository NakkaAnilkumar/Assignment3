using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Define the IOperations interface
    interface IOperations
    {
        void AddToCart(int prodid, string city, int qty, int price);
        void PaymentGateway(int amt, PaymentMode paymentMode);
        void BuyNow();
    }
}
