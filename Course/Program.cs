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

            ComboDevice cd = new ComboDevice() { SerialNumber = 8641 };
            cd.ProcessDoc("My work DJR");
            cd.Print("My work DJR");
            Console.WriteLine(cd.Scan());
        }
    }
}
