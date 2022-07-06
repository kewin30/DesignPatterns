using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Checkbox : Component
    {
        public void Select()
        {
            Console.WriteLine("Checkbox selected");
            this._mediator.Notify(this, "Checkboxselected");
        }
        public void SaveValue()
        {
            Console.WriteLine("Checkbox value saved");
        }
    }
}
