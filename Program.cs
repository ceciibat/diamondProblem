using Fix.Devices;
using Fix.Entities;
using System.Globalization;

namespace Fix.Entities;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer() { SerialNumber = 1080 };
        p.ProcessDoc("My letter");
        p.Print("My letter");

        Scanner s = new Scanner() { SerialNumber = 2003 };
        s.ProcessDoc("My email");
        Console.WriteLine(s.Scan());

        ComboDevice c = new ComboDevice() { SerialNumber = 3921 };  // agora o combo device é tanto um quanto outro
        c.ProcessDoc("My dissertation");
        c.Print("My dissertation");
        Console.WriteLine(c.Scan());
    }
}
