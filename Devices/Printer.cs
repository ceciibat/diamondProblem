using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix.Devices
{
    class Printer : Device, IPrinter                                 // herda da classe abstrata e implementa a interface.
    {
        public override void ProcessDoc(string document)             // sobrescreve o método abstrato (é obrigatório sobrescrever!)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)                          // isso é do contrato
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
