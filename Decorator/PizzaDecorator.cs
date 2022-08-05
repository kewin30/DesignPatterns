using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PizzaDecorator : Ipizza
    {
        private Ipizza _pizza;
        protected PizzaDecorator(Ipizza ipizza)
        {
            _pizza = ipizza;
        }
        public virtual double CalculatePrice()
        {
            return _pizza.CalculatePrice();
        }
    }
}
