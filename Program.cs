using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            Console.Clear();
            Console.WriteLine("1.	Addition:");
            Console.WriteLine("2.	Subtraction:");
            Console.WriteLine("3.	Multiplication:");
            Console.WriteLine("4.	Division:");
            Console.WriteLine("Please enter your choice");
            string opt = Console.ReadLine();

            if (string.IsNullOrEmpty(opt)) { Console.WriteLine("Please choose numbers between 1 and 4"); goto Start; }
            if (Convert.ToInt32(opt) <= 0 || Convert.ToInt32(opt) > 4) { Console.WriteLine("Please choose numbers between 1 and 4"); goto Start; }
            Console.WriteLine("You have choosen: " + opt);

        FirstInPut:
            Console.WriteLine("Enter the first Number:");
            string first = Console.ReadLine();
            if (string.IsNullOrEmpty(first) || !Calculate.IsValidNumber(first)) { Console.WriteLine("Please enter a valid number:"); goto FirstInPut; }

        SecondInPut:
            Console.WriteLine("Enter the second Number:");
            string second = Console.ReadLine();
            if (string.IsNullOrEmpty(second) || !Calculate.IsValidNumber(second)) { Console.WriteLine("Please enter a valid number:"); goto SecondInPut; }

            decimal firstNum; decimal secondNum; decimal result;
            firstNum = Convert.ToDecimal(first);
            secondNum = Convert.ToDecimal(second);

            if (Convert.ToInt32(opt) == 4 && secondNum == 0) { Console.WriteLine("Cant divide by zero"); return; }
            result = Calculate.CalculeResult(Convert.ToInt32(opt), firstNum, secondNum);
            Console.WriteLine("The Result is = " + result);
        }
    }
}