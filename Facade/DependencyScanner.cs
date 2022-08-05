﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class DependencyScanner
    {
        public IEnumerable<string> DependencyScan(string githubUrl)
        {
            Console.WriteLine("Dependency scan");
            return new List<string>() { "Dependency scan Error1" };
        }
    }
}
