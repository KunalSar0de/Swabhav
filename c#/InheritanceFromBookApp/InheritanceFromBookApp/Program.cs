using System;

namespace InheritanceFromBookApp
{
    class Program
    {
        //IS-A relationship works in only one direction!
        public static void Main()
        {
            Surgen s = new Surgen();
            s.SuggestOperation();
            FamilyDoc f1 = new FamilyDoc();
            f1.TreatPatients();
            Console.ReadLine();
        }
    }
    public class Doctor
    {   
        public bool treat;
        public void TreatPatients()
        {
            Console.WriteLine("I treat patients");
            
        }        
    }

    public class FamilyDoc : Doctor
    {
        public bool makeHouseCall;
        public void GiveAdvice()
        {
            Console.WriteLine("I give advice to patients");
        }
    }
    public class Surgen : Doctor
    {
        public bool doOperation;
        public void SuggestOperation()
        {
            Console.WriteLine("I suggest operations");
        }
    }
}
