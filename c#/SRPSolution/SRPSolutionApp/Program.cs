using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPSolutionApp.Model;
namespace SRPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice i = new Invoice(1, "power generator invoice", 120000, 10f, 50f);          
            //InvoiceConsoleGenerator invoiceConsole = new InvoiceConsoleGenerator(i); 
            InvoiceHtmlGenerator htmlGenerator = new InvoiceHtmlGenerator(i);
            Console.ReadKey();
        }
    }
}
