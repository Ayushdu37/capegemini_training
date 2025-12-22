using System;

namespace DebitMenu{
    class Debit{


        public void ATMWithdrawalLimitValidation(){
            Console.Write("Enter your Withdraw Amount : ");
            int WithdrawalAmount = int.Parse(Console.ReadLine());

            int limit = 40000;

            if(WithdrawalAmount <= limit){
                Console.WriteLine("Withdrawal permitted within daily limit.");
            }else{
                Console.WriteLine("Daily ATM withdrawal limit exceeded. ");
            }

        }

        public void EMIBurdenEvaluation(){
            Console.Write("Enter your Monthly Income : ");
            int monthly_income = int.Parse(Console.ReadLine());

            Console.Write("Enter your EMI Amount : ");
            int emi_amount = int.Parse(Console.ReadLine());

            if(emi_amount <= 40 * monthly_income / 100){
                Console.WriteLine("EMI is financially manageable.");
            }else{
                Console.WriteLine("EMI exceeds safe income limit.");
            }
        }

        public void TransactionBasedDailySpendingCalculator(){
            Console.Write("Enter your number of transactions : ");
            int transaction = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Transactions : ");
            int sum = 0;
            for(int i=0; i < transaction; i++){
                int amount = int.Parse(Console.ReadLine());
                if(amount < 0){
                    Console.WriteLine("Invalid Amount.");
                    continue;
                }
                sum += amount;
            }

            Console.WriteLine($"Total debit amount for the day: ₹{sum}");
        }

        public void MinimumBalanceComplianceCheck(){
            Console.Write("Enter your Current Balance : ");
            int current_balance = int.Parse(Console.ReadLine());
            int min_balance = 2000;

            if(current_balance < min_balance){
                Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
            }else{
                Console.WriteLine("Minimum balance requirement satisfied.");
            }
        }

        
        public void DebitMenu(){
            bool check = true;
            while(check){
                Console.WriteLine("1. ATM Withdrawal Limit Validation");
                Console.WriteLine("2. EMI Burden Evaluation");
                Console.WriteLine("3. Transaction-Based Daily Spending Calculator");
                Console.WriteLine("4. Minimum Balance Compliance Check");
                Console.WriteLine("5. Go Back");

                int start = int.Parse(Console.ReadLine());

                switch(start){
                    case 1:
                        ATMWithdrawalLimitValidation();
                        break;
                    case 2:
                        EMIBurdenEvaluation();
                        break;
                    case 3:
                        TransactionBasedDailySpendingCalculator();
                        break;
                    case 4:
                        MinimumBalanceComplianceCheck();
                        break;
                    case 5:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;

                }
            }
        }
    }
}