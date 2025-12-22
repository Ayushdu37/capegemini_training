using System;

namespace CreditMenu{
    class Credit{

        public void NetSalaryCreditCalculation(){
            Console.Write("Enter your Gross Salary : ");
            int gross_salary = int.Parse(Console.ReadLine());
            int deduction = gross_salary * 10 / 100;
            int net_salary = gross_salary - deduction;
            Console.WriteLine($"Net salary credited: ₹{net_salary}");
        }

        public void FixedDepositMaturityCalculation(){
            Console.Write("Enter your Principal Amount : ");
            int principal = int.Parse(Console.ReadLine());

            Console.Write("Enter your Rate of Interest : ");
            int roi = int.Parse(Console.ReadLine());

            Console.Write("Enter your Time Period in Months : ");
            int time = int.Parse(Console.ReadLine());

            int simple_interest = principal * roi * time / 100;

            int maturity_amount = principal + simple_interest;

            Console.WriteLine($"Fixed Deposit maturity amount: ₹{maturity_amount}");
        }

        public void CreditCardRewardPointsEvaluation(){
            Console.Write("Enter your Total Spending : ");
            int total_spending = int.Parse(Console.ReadLine());

            int reward = total_spending / 100;

            Console.WriteLine($"Reward points earned: {reward}");
        }

        public void EmployeeBonusEligibilityCheck(){
            Console.Write("Enter your Annual Salary : ");
            int annual_salary = int.Parse(Console.ReadLine());

            Console.Write("Enter your Years Of Service : ");
            int yos = int.Parse(Console.ReadLine());

            if(annual_salary >= 500000 && yos >= 3){
                Console.WriteLine("Employee is eligible for bonus.");
            }else{
                Console.WriteLine("Employee is not eligible for bonus.");
            }
            
        }

        public void CreditMenu(){
            bool check = true;
            while(check){
                Console.WriteLine("1. Net Salary Credit Calculation");
                Console.WriteLine("2. Fixed Deposit Maturity Calculation");
                Console.WriteLine("3. Credit Card Reward Points Evaluation");
                Console.WriteLine("4. Employee Bonus Eligibility Check");
                Console.WriteLine("5. Go Back");

                int start = int.Parse(Console.ReadLine());

                switch(start){
                    case 1:
                        NetSalaryCreditCalculation();
                        break;
                    case 2:
                        FixedDepositMaturityCalculation();
                        break;
                    case 3:
                        CreditCardRewardPointsEvaluation();
                        break;
                    case 4:
                        EmployeeBonusEligibilityCheck();
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