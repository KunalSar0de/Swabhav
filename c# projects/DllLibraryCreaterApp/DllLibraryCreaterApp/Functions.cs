namespace Ownlibrary
{
    public static class Functions
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public static float Remainder(double num1, double num2)
        {
            float foo = (float)num1;
            float foo1 = (float)num2;
            return foo%foo1;
        }
        public static string IsEvenOrOdd(double num1)
        {
            if (num1 % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        public static string IsPrimeOrNonPrime(double num1)
        {
            int flag = 0;
            double foo = num1 / 2;
            for (int i = 2; i <= foo; i++)
            {
                if (num1 % i == 0)
                {
                    flag = 1;
                    return "Non Prime";
                }
            }
            if (flag == 0)
            {
                return "Prime";
            }
            return "Non Prime";
        }
    }
}


        
