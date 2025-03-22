using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy
{
    public class PayPalPayment : IPaymentStrategy
    {
        string email { get; set; }
        string password { get; set; }

        public PayPalPayment(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Pay {amount} by PayPal ");

        }
    }
}
