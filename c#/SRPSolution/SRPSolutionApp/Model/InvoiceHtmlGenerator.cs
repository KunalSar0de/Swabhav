using System;
using System.IO;

namespace SRPSolutionApp.Model
{
    class InvoiceHtmlGenerator
    {
        public InvoiceHtmlGenerator(Invoice invoice)
        {
            PrintDetails(invoice);
        }
        public void PrintDetails(Invoice invoice)
        {            
            string html = "<table cellpadding='1' cellspacing='0' style='width:30%;border:1px solid black;;font-size: 9pt;font-family:arial;'>";

            html += "<h1>Invoice</h1>";
            html += "<tr>";
            html += "<td><h3> Invoice Id:<h3></td>";
            html += "<td><h3>" + invoice.Id + "</h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Discription:<h3></td>";
            html += "<td><h3>" + invoice.Discprition + "</h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Tax Applied:<h3></td>";
            html += "<td><h3>" + invoice.TaxOnInvoice + "%</h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Discount Applied:<h3></td>";
            html += "<td><h3>" + invoice.DiscountOnInvoice + "%</h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Discount Amount:<h3></td>";
            html += "<td><h3>" + invoice.CalculateDiscount() + "</h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Tax Amount:<h3></td>";
            html += "<td><h3>" + invoice.CalculateTax() + "</h3></td>";
            html += "</tr>";

            html += "<tr>";
            html += "<td><h3> Invoice Final Amount:<h3></td>";
            html += "<td><h3>" + invoice.CalculateFinalAmount() + "</h3></td>";
            html += "</tr>";

            File.WriteAllText(@"E:\swabhav\c#\OOP\SRPSolution\Console.html", html);
            Console.WriteLine("HTML File created.");
        }
    }
}
