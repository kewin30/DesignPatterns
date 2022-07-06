using System;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PdfGenerator pdfGenerator = new PdfGenerator();

            Console.WriteLine("**PDF**");
            pdfGenerator.GenerateReport();

            Console.WriteLine("**CSV**");
            CsvGenerator csvGenerator = new CsvGenerator();
            csvGenerator.GenerateReport();
        }
    }
}
