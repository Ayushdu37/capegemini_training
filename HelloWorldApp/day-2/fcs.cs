// Console.WriteLine("Main Menu");
//         bool check = true;

//         while (check)
//         {
//             Console.WriteLine("\n1. Check Loan Eligibility");
//             Console.WriteLine("2. Income Tax Calculation");
//             Console.WriteLine("3. Enter Transactions");
//             Console.WriteLine("4. Exit");

//             int start = Convert.ToInt32(Console.ReadLine());

//             switch (start)
//             {
//                 case 1:
//                     Console.WriteLine("Enter Your Age:");
//                     int age = Convert.ToInt32(Console.ReadLine());

//                     Console.WriteLine("Enter your Monthly Income:");
//                     int income = Convert.ToInt32(Console.ReadLine());

//                     if (age >= 21 && income >= 30000)
//                         Console.WriteLine("You are Eligible for the Loan.");
//                     else
//                         Console.WriteLine("You are Not Eligible for the Loan.");
//                     break;

//                 case 2:
//                     Console.WriteLine("Enter your Annual Income:");
//                     int annual_income = Convert.ToInt32(Console.ReadLine());

//                     if (annual_income <= 250000)
//                     {
//                         Console.WriteLine("You have no Income Tax.");
//                     }
//                     else if (annual_income <= 500000)
//                     {
//                         Console.WriteLine("You have 5% Income Tax.");
//                         Console.WriteLine($"Your Annual Income = ₹{annual_income}");
//                         int tax = annual_income * 5 / 100;
//                         Console.WriteLine($"Tax = ₹{tax}");
//                         Console.WriteLine($"Total Income After Tax = ₹{annual_income - tax}");
//                     }
//                     else if (annual_income <= 1000000)
//                     {
//                         Console.WriteLine("You have 10% Income Tax.");
//                         Console.WriteLine($"Your Annual Income = ₹{annual_income}");
//                         int tax = annual_income * 10 / 100;
//                         Console.WriteLine($"Tax = ₹{tax}");
//                         Console.WriteLine($"Total Income After Tax = ₹{annual_income - tax}");
//                     }
//                     else
//                     {
//                         Console.WriteLine("You have 30% Income Tax.");
//                         Console.WriteLine($"Your Annual Income = ₹{annual_income}");
//                         int tax = annual_income * 30 / 100;
//                         Console.WriteLine($"Tax = ₹{tax}");
//                         Console.WriteLine($"Total Income After Tax = ₹{annual_income - tax}");
//                     }
//                     break;

//                 case 3:
//                     int sum = 0;
//                     Console.WriteLine("Enter 5 transaction amounts:");

//                     for (int i=1; i<=5; i++)
//                     {
//                         int amount = Convert.ToInt32(Console.ReadLine());

//                         if (amount < 0)
//                         {
//                             Console.WriteLine("Invalid Amount");
//                             continue;
//                         }

//                         sum += amount;
//                     }

//                     Console.WriteLine($"Total debit amount for the day: ₹{sum}");
//                     break;

//                 case 4:
//                     check = false;
//                     Console.WriteLine("Program Exited.");
//                     break;

//                 default:
//                     Console.WriteLine("Invalid Input");
//                     break;
//             }
//         }