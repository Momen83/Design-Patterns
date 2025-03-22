using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Strategy
{
    public interface IPaymentStrategy
    {
        public void ProcessPayment(double amount);
    }
}
