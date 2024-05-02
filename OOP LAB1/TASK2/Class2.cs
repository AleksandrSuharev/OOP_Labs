using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace TASK2
{
    internal class Class2
    {
        static async Task Main()
        {
                IDateTimePrinter europeanDateTimePrinter = new EuropeanDateTimePrinter();
                IDateTimePrinter americanDateTimePrinter = new AmericanDateTimePrinter();

                IDateTimePrinter decoratedEuropeanDateTime = new SuffixDecorator(new PrefixDecorator(europeanDateTimePrinter, "AAA"), "SSS");
                IDateTimePrinter decoratedAmericanDateTime = new SuffixDecorator(new PrefixDecorator(americanDateTimePrinter, "AAA "), "SSS");
                IDateTimePrinter x = new PrefixDecorator(new SuffixDecorator(new PrefixDecorator(americanDateTimePrinter, "AAA "), "SSS"), "28");

            while (true)
            {
                Console.WriteLine("Decorated European DateTime: " + decoratedEuropeanDateTime.Print());
                Console.WriteLine("Decorated American DateTime: " + decoratedAmericanDateTime.Print());
                Console.WriteLine(x.Print());
               
                await Task.Delay(1000);
                Console.Clear();
            }
        }
    }
}
