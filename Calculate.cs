namespace Calculation
{
    public class Calculate
    {
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
