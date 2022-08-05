using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediumPizza mediumPizza = new MediumPizza();

            CheesePizzaDecorator mediumPizzaWithCheese = new CheesePizzaDecorator(mediumPizza);
            Console.WriteLine($"MediumPizzaWithCheese: {mediumPizzaWithCheese.CalculatePrice()}");

            SalamiPizzaDecorator p2 = new SalamiPizzaDecorator(mediumPizzaWithCheese);
            Console.WriteLine($"P2: {p2.CalculatePrice()}");

            SalamiPizzaDecorator p3 = new SalamiPizzaDecorator(p2);
            Console.WriteLine($"P3: {p3.CalculatePrice()}");
        }
    }
}
