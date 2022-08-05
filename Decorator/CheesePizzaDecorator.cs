using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CheesePizzaDecorator : PizzaDecorator
    {
        public CheesePizzaDecorator(Ipizza ipizza) : base(ipizza)
        {
        }
        public override double CalculatePrice()
        {
            return base.CalculatePrice()+6;
        }
    }
}
