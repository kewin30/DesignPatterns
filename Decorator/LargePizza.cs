using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class LargePizza : Ipizza
    {
        public double CalculatePrice()
        {
            return 30;
        }
    }
}
