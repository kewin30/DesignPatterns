﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class CsvGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate CSV file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for csv");
        }
    }
}
