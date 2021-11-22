using System;


namespace RulesAssignmentApp
{
    class Program
    {
        static void Main()
        {
            //RuleOneViolation();
            RuleOneWithSolution();  
            Console.ReadLine();
        }
        public static void RuleOneViolation()
        {
            Console.WriteLine("Only One Level Of Indentation Per Method Rule Violation\n");
            int i, j;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                {
                    if ((i % j) == 0)
                    {
                        break;
                    }
                }
                if (j > (i / j))
                {
                    Console.WriteLine("{0} is prime", i);
                }                 
            }
            Console.ReadLine();
        }

        public static void RuleOneWithSolution()
        {
            Console.WriteLine("Only One Level Of Indentation Per Method Rule Solution\n");
            int i;
            for (i = 2; i < 100; i++)
            {
                InternalLogic(i);
            }
            Console.ReadLine();
        }

        private static int InternalLogic(int i)
        {
            int j;
            for (j = 2; j <= (i / j); j++)
            {
                if ((i % j) == 0)
                {
                    break;
                }
            }
            if (j > (i / j))
            {
                Console.WriteLine("{0} is prime", i);
            }
            return j;
        }
    }    
}
