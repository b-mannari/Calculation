using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
    public class Calculate
    {
        public static bool IsValidNumber(string str)
        {
            return decimal.TryParse(str, out decimal num);
        }

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
