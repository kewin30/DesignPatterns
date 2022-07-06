using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class PdfInvoiceSaver : IInvoiceSaver
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("saving invoice as pdf");
        }
    }
}
