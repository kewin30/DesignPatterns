using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class RubberDuck : Duck
    {
        public override void Fly()
        {
            throw new NotImplementedException();
            //Rubber Duck can't fly. Not correct with Listkov Substitution.
        }

        public override void Quack()
        {
            Console.WriteLine("Rubber duck Quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Rubber duck swim");
        }
    }
}
