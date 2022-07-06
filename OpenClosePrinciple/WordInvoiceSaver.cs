using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class WordInvoiceSaver : IInvoiceSaver
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Saving invoice as WORD");
        }
    }
}
