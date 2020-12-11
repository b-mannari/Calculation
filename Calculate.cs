using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
    public class Calculate
    {
        //Method to check if the string passed is a valid decimal number
        public static bool IsValidNumber(string str)
        {
            return decimal.TryParse(str, out decimal num);
        }

        //Method to calculate the result based on the operator, first number and second number
        public static decimal CalculeResult(int opt, decimal firstNum, decimal secondNum)
        {
            decimal result = 0;
            switch (opt)
            {
                case 1:
                    result = firstNum + secondNum;
                    break;
                case 2:
                    result = firstNum - secondNum;
                    break;
                case 3:
                    result = firstNum * secondNum;
                    break;
                case 4:
                    result = firstNum / secondNum;
                    break;
            }
            return result;
        }
    }
}
