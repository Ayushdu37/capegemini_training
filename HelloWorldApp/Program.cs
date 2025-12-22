using System;

class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("Bank System\n");

        Console.Write("Enter your Account Number : ");
        int account_number;
        while(!int.TryParse(Console.ReadLine(), out account_number))
        {
            Console.WriteLine("Invalid Account Number.");
        }

        Console.Write("Enter Initial Balance : ");
        double initBalance;
        while(!double.TryParse(Console.ReadLine(), out initBalance))
        {
            Console.WriteLine("Invalid Balance.");
        }

        BankAccount account = new BankAccount(account_number, initBalance);
        int choice;
        do
        {
            Console.WriteLine("\n1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Display Account");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose option : ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Your Deposit Amount : ");
                    double deposite_amount;
                    if(double.TryParse(Console.ReadLine(), out deposite_amount))
                    {
                        account.Deposit(deposite_amount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount.");
                    }
                    break;
                case 2:
                    Console.Write("Enter Your Withdrawal Amount : ");
                    double withdraw_amount;
                    if(double.TryParse(Console.ReadLine(), out withdraw_amount))
                    {
                        if(account.Withdraw(withdraw_amount, out string message))
                        {
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine(message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount.");
                    }
                    break;
                case 3:
                    account.Display();
                    break;
                case 4:
                    Console.WriteLine("Thank You.");
                    break;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }while(choice != 4);

    }
}
