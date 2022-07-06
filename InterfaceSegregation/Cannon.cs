using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    internal class Cannon : IPrinter, IScanner
    {
        public void PrintColor(string content)
        {
            Console.WriteLine("Cannon print color");
        }

        public void PrintGrey(string content)
        {
            Console.WriteLine("Cannon print grey");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Cannon scan content");
        }
    }
}
