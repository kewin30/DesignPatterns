using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class CityDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("City duck flies");
        }
        public override void Quack()
        {
            Console.WriteLine("City duck quack");
        }

        public override void Swim()
        {
            Console.WriteLine("City duck swim");
        }
    }
}
