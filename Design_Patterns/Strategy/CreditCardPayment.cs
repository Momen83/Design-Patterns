using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        string cardNumber { get; set; }
        DateTime expiryDate { get; set; }
        int CVV { get; set; }

        public CreditCardPayment(string cardNumber, DateTime expiryDate, int cVV)
        {
            this.cardNumber = cardNumber;
            this.expiryDate = expiryDate;
            CVV = cVV;
        }

        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Pay {amount} by credit card ");
        }
    }
}
