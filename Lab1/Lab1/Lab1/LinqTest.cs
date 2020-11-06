/*CIS 200-01
Lab 1
This program uses LINQ to demonstrate sorting data by column, finding ranges in data
and outputting to the console. 
2/4/20
Grading ID T9749*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args)
        {
            int min = 200;//variable to hold the min value
            int max = 500;// variable to hold the max value
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M ) };

            // Display original array
            WriteLine("Original Invoice Data\n");
            WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            WriteLine("----- -------------------- ----- ------");
            var invoiceByPd =//variable to hold the values from invoices to be sorted by part
                from invoice in invoices
                orderby invoice.PartDescription
                select invoice;
            foreach (var i in invoiceByPd)//precondition values brought into be sorted, post values sorted by part and output to console
                WriteLine($"{i}");
            WriteLine("----- -------------------- ----- ------A^");
            var invoiceByPrice =//variable to hold the values from invoices to be sorted by price
                from invoice in invoices
                orderby invoice.Price
                select invoice;
            foreach (var i in invoiceByPrice)//precondition values brought into be sorted, post values sorted by price and output to console
                WriteLine($"{i}");
            WriteLine("----- -------------------- ----- ------B^");
            var invoiceByQuantity =//variable to hold the values from invoices to be sorted by quantity
                from invoice in invoices
                orderby invoice.Quantity
                select new {invoice.PartDescription, invoice.Quantity };
            foreach (var i in invoiceByQuantity)//precondition values brought into be sorted, post values are sorted and output to console with specified columns 
                WriteLine($"{i.Quantity} {i.PartDescription}");
            WriteLine("----- -------------------- ----- ------C^");
            var invoiceByPartDiscription =//variable to hold the values from invoices to calculate total for items
                from invoice in invoices
                let total = invoice.Price * invoice.Quantity
                orderby total
                select new { invoice.PartDescription, InvoiceTotal = total };
            foreach (var i in invoiceByPartDiscription)//precondition values brought into be sorted, post values sorted and output to console with calculated totals
                WriteLine($"{i.PartDescription} {i.InvoiceTotal}");
            WriteLine("----- -------------------- ----- ------D^");
            var Total =//variable to hold the values from invoices to be output if within range 
                from invoice in invoiceByPartDiscription
                where invoice.InvoiceTotal <= max && invoice.InvoiceTotal >= min
                select invoice;
            foreach (var i in Total)//precondition values brought into be sorted, post values sorted and output to console if within specified range
                WriteLine($"{i.PartDescription} {i.InvoiceTotal}");
            WriteLine("----- -------------------- ----- ------E^");

        }
    }
}
