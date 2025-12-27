// Console.Write("Enter the number of products: ");
// int size = int.Parse(Console.ReadLine());

// int[] products = new int[size];
// int sum = 0;
// Console.WriteLine("Enter your product prices: ");
// for(int i=0; i<size; i++)
// {
//     products[i] = int.Parse(Console.ReadLine());
//     if(products[i] < 0)
//     {
//         products[i] = 0;
//     }

//     sum += products[i];
// }

// double avg = (double)sum/size;

// Array.Sort(products);
// for(int i=0; i<products.Length; i++)
// {
//     if(products[i] < avg)
//     {
//         products[i] = 0;
//     }
// }

// Array.Resize(ref products, size + 5);

// for(int i=size; i<products.Length; i++)
// {
//     products[i] = (int)avg;
// }

// Console.WriteLine("Final Array: ");
// for(int i=0; i<products.Length; i++)
// {
//     Console.WriteLine($"Index {i} -> {products[i]}");
// }


