using System;
class BoxingTest 
{
    static public void Main()
{  
        int num = 2020;
        object obj = num; // boxing
        // value of num to be change
        num = 100;
        System.Console.WriteLine("Value - type value of num is : {0}", num);
        System.Console.WriteLine ("Object - type value of obj is : {0}", obj);
    }
}
