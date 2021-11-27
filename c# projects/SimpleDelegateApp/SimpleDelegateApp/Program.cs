using System;


namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage f1;
            f1 = PrintHello;
            f1("Kunal");
            f1 = PrintGoodBye;
            f1("sagar");
            //f1 = Foo;


            MessageWizard(f1);
            MessageWizard(PrintHello);
            MessageWizard(PrintGoodBye);

            Console.WriteLine("\n");
            DPrintMessage f2;
            f2 = PrintGoodBye;
            f2 += PrintHello;
            f2 += PrintGoodBye;
            f2("kunal");
            Console.ReadKey();
        }
        public static void PrintHello(string name)
        {
            Console.WriteLine("Hello Says {0}",name);
        }
        public static void PrintGoodBye(string name)
        {
            Console.WriteLine("GoodBye Says {0}", name);
        }
        public static void Foo()
        {
           
        }
        public static void MessageWizard(DPrintMessage dPrint)
        {
            Console.WriteLine("Inside MessageWizard");            
        }

    }
}
