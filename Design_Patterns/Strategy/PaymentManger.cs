using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy
{
    public class PaymentManger
    {
        IPaymentStrategy paymentStrategy;

       public PaymentManger(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void ChangePaymentMethod(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void Pay(double amount)
        {
            paymentStrategy.ProcessPayment(amount);
        }
    }
}
