using System;

namespace CalculatorApp{
    class Calculator{
        int number1;
        int number2;
        int ans;

        public void Addition(){
            Console.WriteLine("Enter First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            ans = number1 + number2;

            Console.WriteLine($"Sum of the Number is {ans}");
        }

        public void Subtract(){
            Console.WriteLine("Enter First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            ans = number1 - number2;

            Console.WriteLine($"Subtraction of the Number is {ans}");
        }

        public void Multiply(){
            Console.WriteLine("Enter First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            ans = number1 * number2;

            Console.WriteLine($"Multiplication of the Number is {ans}");
        }

        public void Divide(){
            Console.WriteLine("Enter First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            ans = number1 / number2;

            Console.WriteLine($"Division of the Number is {ans}");
        }

        public void Remainder(){
            Console.WriteLine("Enter First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            ans = number1 % number2;

            Console.WriteLine($"Remainder of the Number is {ans}");
        }
    }
}