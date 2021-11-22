using System;


namespace StringImmutablityCheckApp
{
    //when we get string, space is created in the managed heap that holds the reference
    //of string.
    class Program
    {       
        static void Main()
        {
            Case1();           
            Console.ReadLine();
        }
        public static void Case1()
        {
            string str = " ";
            for (int i = 0; i < 100000; i++)//str=0//str=1//str=2
            {
                str = i.ToString();
            }
            Console.WriteLine(str);
        }
        public static void Case2()
        {
            int i;
            for ( i = 0; i < 100; i++)//str=0//str=1//str=2
            {
               
            }
            Console.WriteLine(i);
        }
    }
}
