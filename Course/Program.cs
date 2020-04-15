using System;
using Course.Devices;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 2457 };
            p.ProcessDoc("DjPrinter");
            p.Print("Printer Djr");

            Scanner s = new Scanner() { SerialNumber = 5781 };
            s.ProcessDoc("DjScanner");
            Console.WriteLine(s.Scan());
        }
    }
}
