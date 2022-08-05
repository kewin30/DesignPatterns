using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SalamiPizzaDecorator : PizzaDecorator
    {
        public SalamiPizzaDecorator(Ipizza ipizza) : base(ipizza)
        {
        }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() + 7;
        }
    }
}
