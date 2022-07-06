using System;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            Checkbox checkbox = new Checkbox();

            new RegisterClientView(checkbox, button);

            button.Click();
            checkbox.Select();
        }
    }
}
