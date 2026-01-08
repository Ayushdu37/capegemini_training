using System;

namespace EcommerceAssessment
{
    public class OrderProcessor
    {
        public event Action<string> OrderProcessed;
        public void ProcessOrder(Order order,
         Func<double, double> taxCalculator,
          Func<double, double> discountCalculator,
          Predicate<Order> validator,
          OrderCallback callback)
        {
            if (!validator(order))
            {
                callback("Order validation failed.");
            }
            double tax = taxCalculator(order.Amount);
            double discount = discountCalculator(order.Amount);

            order.Amount = order.Amount + tax - discount;

            callback("Order Processed successfully.");

            OrderProcessed?.Invoke($"Order {order.OrderId} processed.");
        }
    }
}