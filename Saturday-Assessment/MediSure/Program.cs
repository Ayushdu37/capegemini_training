class Program
{
    public static PatientBill lastBill;
    public static bool HasLastBill;

    public static void RegisterBill()
    {
        PatientBill patientBill = new PatientBill();

        Console.Write("Enter Bill Id: ");
        string billId = Console.ReadLine();
        patientBill.BillId = billId;

        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();
        patientBill.PatientName = name;

        Console.Write("Is the patient insured? (Y/N): ");
        string insurance = Console.ReadLine();
        if (insurance == "Y" || insurance == "y")
        {
            patientBill.HasInsurance = true;
        }
        else
        {
            patientBill.HasInsurance = false;
        }

        Console.Write("Enter Consultation Fee: ");
        decimal fee = decimal.Parse(Console.ReadLine());
        patientBill.ConsultationFee = fee;

        Console.Write("Enter Lab Charges: ");
        decimal labCharges = decimal.Parse(Console.ReadLine());
        patientBill.LabCharges = labCharges;

        Console.Write("Enter Medicine Charges: ");
        decimal medCharges = decimal.Parse(Console.ReadLine());
        patientBill.MedicineCharges = medCharges;

        Console.WriteLine("Bill created successfully.");

        patientBill.CalculateGrossAmount();
        patientBill.CalculateDiscountAmount();
        patientBill.CalculateFinalPayable();

        lastBill = patientBill;
        HasLastBill = true;
        Console.WriteLine("-----------------------------------------------------------");
    }

    public static void ViewBill()
    {
        if (HasLastBill)
        {
            Console.WriteLine("----------- Last Bill -----------");
            Console.WriteLine($"BillId : {lastBill.BillId}");
            Console.WriteLine($"Patient: {lastBill.PatientName}");
            if (lastBill.HasInsurance == true)
            {
                Console.WriteLine($"Insured: Yes");
            }
            else
            {
                Console.WriteLine($"Insured: No");
            }
            Console.WriteLine($"Consultation Fee: {lastBill.ConsultationFee}");
            Console.WriteLine($"Lab Charges: {lastBill.LabCharges}");
            Console.WriteLine($"Medicine Charges: {lastBill.MedicineCharges}");
            Console.WriteLine($"Gross Amount: {lastBill.GrossAmount}");
            Console.WriteLine($"Discount Amount: {lastBill.DiscountAmount}");
            Console.WriteLine($"Final Payable: {lastBill.FinalPayable}");
            Console.WriteLine("--------------------------------");
        }
        else
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
        }
    }

    public static void ClearBill()
    {
        lastBill = null;
        HasLastBill = false;
        Console.WriteLine("Bill Cleared.");
    }


    public static void Main()
    {
        bool check = true;

        while (check)
        {
            Console.WriteLine("================ MediSure Clinic Billing ================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");

            Console.WriteLine();

            Console.Write("Enter your option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RegisterBill();
                    break;

                case 2:
                    ViewBill();
                    break;

                case 3:
                    ClearBill();
                    break;

                case 4:
                    check = false;
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;
            }
        }
    }
}


