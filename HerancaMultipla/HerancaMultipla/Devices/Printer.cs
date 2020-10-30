using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultipla.Devices
{
    class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }
        
        public string Print(string document)
        {
            return "Printer print result";
        }
    }
}
