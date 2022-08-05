using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class MediumPizza : Ipizza
    {
        public double CalculatePrice()
        {
            return 20;
        }
    }
}
