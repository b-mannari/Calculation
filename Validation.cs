using System;

namespace Calculation
{
    //Validation class for various methods 
    class Validation
    {
        //Method to check if the selected option is valid
        public static bool IsValidOption(string opt)
        {
            //Check if the input option value is not empty
            if (string.IsNullOrEmpty(opt) || Convert.ToInt32(opt) < 1 || Convert.ToInt32(opt) > 4)
            {
                return false;
            }
            return true;
        }

        //Method to check if the string passed is a valid decimal number
        public static bool IsValidNumber(string str)
        {
            return decimal.TryParse(str, out decimal num);
        }

        public static bool isValidInPutValue(string inputVal)
        {
            if (string.IsNullOrEmpty(inputVal) || !IsValidNumber(inputVal))
            {
                return false;
            }
            return true;
        }

        //Display error when the option selected is division and second number is Zero 
        public static bool checkIsDivideByZero(int opt, decimal secondNum)
        {
            if (Convert.ToInt32(opt) == 4 && secondNum == 0)
            {
                return false;
            }
            return true;
        }
    }
}
