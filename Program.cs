using System;

namespace Calculation
{
    //console calculator application
    class Program
    {
        static void Main(string[] args)
        {

        Start:
            //Display user with options to choose
            Console.Clear();
            Console.WriteLine("1.	Addition:");
            Console.WriteLine("2.	Subtraction:");
            Console.WriteLine("3.	Multiplication:");
            Console.WriteLine("4.	Division:");
            Console.WriteLine("Please enter your choice");
            string opt = Console.ReadLine();

            if (!Validation.IsValidOption(opt))
            {
                Console.WriteLine("Please choose numbers between 1 and 4"); goto Start;
            }
            Console.WriteLine("You have choosen: " + opt);

        FirstValInPut:
            Console.WriteLine("Enter the first Number:");
            string first = Console.ReadLine();
            //Check if the first number is not empty and is valid number
            if (!Validation.isValidInPutValue(first))
            {
                Console.WriteLine("Please enter a valid number:"); goto FirstValInPut;
            }

        SecondValInPut:
            Console.WriteLine("Enter the second Number:");
            string second = Console.ReadLine();
            //Check if the second number is not empty and is valid number
            if (!Validation.isValidInPutValue(second))
            {
                Console.WriteLine("Please enter a valid number:"); goto SecondValInPut;
            }

            //Convert the input values to valid numbers 
            decimal firstNum = Convert.ToDecimal(first);
            decimal secondNum = Convert.ToDecimal(second);

            //Display error when the option selected is division and second number is Zero 
            if (!Validation.checkIsDivideByZero(Convert.ToInt32(opt), secondNum))
            {
                Console.WriteLine("Cant divide by zero"); return;
            }

            //Pass the Option value, first number and the second number to CalculeResult method to get the required result
            decimal result = Calculate.CalculeResult(Convert.ToInt32(opt), firstNum, secondNum);
            Console.WriteLine("The Result is = " + result);
        }
    }
}