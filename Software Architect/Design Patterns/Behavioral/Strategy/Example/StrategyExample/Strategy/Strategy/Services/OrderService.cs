using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class OrderService
    {
        private readonly IPaymentStrategy _payment;

        public OrderService(IPaymentStrategy payment)
        {
            _payment = payment;
        }

        public string ValidatePurchase(decimal budget)
        {
            return _payment.Purchase(budget);
        }
    }
}
