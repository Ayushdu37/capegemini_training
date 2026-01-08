// static void DisplayStatus(string message)
//     {
//         Console.WriteLine($"Callback: {message}");
//     }


// // ====== TASK-1 ====== //

//         Repository<string> productRepository = new Repository<string>();
//         productRepository.Add("Laptop");
//         productRepository.Add("Mobile");
//         productRepository.Add("Headphones");

//         Console.WriteLine("Products in Repository: ");

//         foreach (var item in productRepository.GetAll())
//         {
//             Console.WriteLine(item);
//         }


//         // ====== TASK-2 ====== //

//         Order order = new Order();
//         order.OrderId = 101;
//         order.CustomerName = "Alice";
//         order.Amount = 5000;

//         Console.WriteLine(order);

//         // ====== TASK-3 ====== //

//         OrderCallback callback = DisplayStatus;

//         callback("Order validation failed.");

//         // ====== TASK-4 ====== //

//         Order order1 = new Order();
//         order1.OrderId = 102;
//         order1.CustomerName = "Bob";
//         order1.Amount = 500;

//         OrderProcessor processor = new OrderProcessor();

//         Func<double, double> taxCalculator = amount => amount * 0.10;
//         Func<double, double> discountCalculator = amount => amount * 0.05;
//         Predicate<Order> validator = o => o.Amount >= 1000;

//         OrderCallback callback1 = message =>
//         {
//             Console.WriteLine($"Callback: {message}");
//         };

//         processor.ProcessOrder(order, taxCalculator, discountCalculator, validator, callback);