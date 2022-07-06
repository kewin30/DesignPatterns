using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class PdfGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate PDF file");
        }
        protected override void GetData()
        {
            Console.WriteLine("PDF get data override");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for pdf file");
        }
    }
}
