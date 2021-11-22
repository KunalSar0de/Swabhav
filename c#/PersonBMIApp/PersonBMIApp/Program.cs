using System;
using PersonBMIApp.Model;

namespace PersonBMIApp
{
    class Program
    {
        static void Main()
        {
            Person[] p = new Person[2];
            p[0] = new Person("Kunal", 47f, 74.37f, 20, "Male");
            p[1] = new Person("vijay", 76.3f, 63.78f, 22, "Male");
            p[0].PersonWorkout();
            //p[0].EatPerson();
            PrintArrayInfo(p);
            Console.ReadLine();
        }

        public static void PrintArrayInfo(Person[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                PrintDetails(p[i]);
            }
        }

        public static void PrintDetails(Person p)
        {
            Console.WriteLine("\nName   : {0} \nWeight : {1}kg \nHeight : {2:F2}m \nAge    : {3} \nGender : {4}", p.GetName(), p.GetWeight(), p.GetHeight(), p.GetAge(), p.GetGender());
            Console.WriteLine("\nAfter Workout:");
            Console.WriteLine("Your weight loss by: {0}", p.GetLossWeight());
            Console.WriteLine("\nBMI is: {0:F2}", p.CalcBMI());            
            Console.WriteLine("Your weight status: {0}", p.GetBodyStrucure());
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}

