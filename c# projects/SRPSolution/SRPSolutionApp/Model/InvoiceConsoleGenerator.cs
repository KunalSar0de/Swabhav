using System;


namespace SRPSolutionApp.Model
{
    class InvoiceConsoleGenerator
    {
        public InvoiceConsoleGenerator(Invoice invoice)
        {
            PrintDetails(invoice);
        }
        public void PrintDetails(Invoice invoice)
        {
            Console.WriteLine("Invoice Id: {0}", invoice.Id);
            Console.WriteLine("Invoice Description: {0}",invoice.Discprition);
            Console.WriteLine("Invoice Amount: {0}", invoice.Amount);
            Console.WriteLine("Invoice GST tax: {0}%", invoice.TaxOnInvoice);
            Console.WriteLine("Invoice Discount: {0}%", invoice.DiscountOnInvoice);
            Console.WriteLine("Discounted amount: {0}", invoice.CalculateDiscount());
            Console.WriteLine("Tax amount: {0}", invoice.CalculateTax());
            Console.WriteLine("Final amount: {0}", invoice.CalculateFinalAmount());
            Console.WriteLine("----------------------------------------------------");

        }
    }
}
