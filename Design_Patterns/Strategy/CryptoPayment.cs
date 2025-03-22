using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy
{
    public class CryptoPayment : IPaymentStrategy
    {
        string WalletAdress { get; set; }

        public CryptoPayment(string WalletAdress)
        {
            this.WalletAdress = WalletAdress;
        }
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Pay {amount} by crypto ");
        }
    }
}
