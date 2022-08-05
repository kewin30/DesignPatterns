using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScanFacade scanFacade = new ScanFacade();
            scanFacade.Scan("http://github.com/somerepo");
        }
    }
}
