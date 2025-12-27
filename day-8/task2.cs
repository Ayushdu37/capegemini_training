// Console.Write("Enter the number of branches: ");
// int branches = int.Parse(Console.ReadLine());

// Console.Write("Enter the number of months: ");
// int months = int.Parse(Console.ReadLine());

// int[,] sales = new int[branches,months];

// for(int i = 0; i < branches; i++)
// {
//     for(int j = 0; j < months; j++)
//     {
//         sales[i,j] = int.Parse(Console.ReadLine());
//     }
// }

// int highestSale = sales[0,0];

// for(int i=0; i<branches; i++)
// {
//     int branchTotal = 0;
//     for(int j=0; j<months; j++)
//     {
//         branchTotal += sales[i,j];

//         if(sales[i,j] > highestSale)
//         {
//             highestSale = sales[i,j];
//         }
//     }
//     Console.WriteLine($"Total sales for Branch {i + 1}: {branchTotal}");
// }

// Console.WriteLine($"Highest branch totals and global highest sale: {highestSale}");