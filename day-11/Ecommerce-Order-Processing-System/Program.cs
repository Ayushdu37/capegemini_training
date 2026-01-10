// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using EcommerceAssessment;

class Program
{
    public static void Main()
    {
        // ====== TASK-5 ====== //

        Repository<Order> repository = new Repository<Order>();

        repository.Add(new Order{OrderId = 1, CustomerName = "Alice", Amount = 5000});
        repository.Add(new Order{OrderId = 2, CustomerName = "Bob", Amount = 2000});
        repository.Add(new Order{OrderId = 3, CustomerName = "Charlie", Amount = 8000});

        Func<double, double> taxCalculator = amount => amount * 0.20;
        Func<double, double> discountCalculator = amount => amount * 0.10;
        Predicate<Order> validator = order => order.Amount >= 3000;

        OrderCallback callback = message =>
        {
            Console.WriteLine($"Callback: {message}");
        };

        OrderProcessor processor = new OrderProcessor();

        Action<string> logger = message =>
        {
            Console.WriteLine($"Logger: Event: {message}");
        };

        Action<string> notifier = message =>
        {
            Console.WriteLine($"Notifier: Event: {message}");
        };

        processor.OrderProcessed += logger;
        processor.OrderProcessed += notifier;

        foreach(var order in repository.GetAll())
        {
            processor.ProcessOrder(order, taxCalculator, discountCalculator, validator, callback);
            Console.WriteLine();
        }

        List<Order> orders = repository.GetAll();
        orders.Sort((a, b) => b.Amount.CompareTo(a.Amount));

        Console.WriteLine("Sorted Orders (Descending Amount): ");
        foreach(var order in orders)
        {
            Console.WriteLine(order);
        }
    }
}


