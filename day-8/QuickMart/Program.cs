class Program
{
    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction;

    public static void RegisterTransaction()
    {
        SaleTransaction transaction = new SaleTransaction();

        string invoice;
        do
        {
            Console.Write("Enter Invoice No: ");
            invoice = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(invoice)) Console.WriteLine("Invoice No. cannot be empty. Please try again.");
            
        }while(string.IsNullOrWhiteSpace(invoice));
        transaction.InvoiceNo = invoice;

        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();
        transaction.CustomerName = name;

        Console.Write("Enter Item Name: ");
        string item = Console.ReadLine();
        transaction.ItemName = item;

        int quantity;
        do
        {
            Console.Write("Enter Quantity: ");
            quantity = int.Parse(Console.ReadLine());
            if (quantity < 0)
            {

                Console.WriteLine("Enter Valid Quantity");
            }
        } while (quantity <= 0);
        transaction.Quantity = quantity;

        decimal purchaseAmount;
        do
        {
            Console.Write("Enter Purchase Amount (total): ");
            purchaseAmount = decimal.Parse(Console.ReadLine());
            if (purchaseAmount < 0)
            {
                Console.WriteLine("Enter Valid Purchase Amount");
            }
        } while (purchaseAmount <= 0);
        transaction.PurchaseAmount = purchaseAmount;

        decimal sellingAmount;
        do
        {
            Console.Write("Enter Selling Amount (total): ");
            sellingAmount = decimal.Parse(Console.ReadLine());
            if (sellingAmount >= 0)
            {
                Console.WriteLine("Enter Valid Selling Amount");
            }
        } while (sellingAmount <= 0);
        transaction.SellingAmount = sellingAmount;

        Console.WriteLine();

        transaction.Status();
        transaction.purchase_amount();
        transaction.profitMarginPercent();

        Console.WriteLine("Transaction saved successfully.");
        Console.WriteLine($"Status: {transaction.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {transaction.ProfitOrLossAmount}");
        Console.WriteLine($"Profit Margin (%): {transaction.ProfitMarginPercent}");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();

        LastTransaction = transaction;
        HasLastTransaction = true;
    }
    public static void ViewTransaction()
    {
        if (HasLastTransaction == true)
        {
            Console.WriteLine("-------------- Last Transaction --------------");
            Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
            Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
            Console.WriteLine($"Item: {LastTransaction.ItemName}");
            Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
            Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount}");
            Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount}");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
        }
    }
    public static void CalculateTransaction()
    {
        if (HasLastTransaction == true)
        {
            Console.WriteLine("-------------- Last Transaction Profit/Loss --------------");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
        }
    }
    public static void Main()
    {
        bool check = true;

        while (check)
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");

            Console.WriteLine();

            Console.Write("Enter your option: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    RegisterTransaction();
                    break;

                case 2:
                    ViewTransaction();
                    break;

                case 3:
                    CalculateTransaction();
                    break;

                case 4:
                    check = false;
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;
            }
        }
    }
}