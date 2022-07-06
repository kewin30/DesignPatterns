using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber1 = new Subscriber("sub1");
            Subscriber subscriber2 = new Subscriber("sub2");

            Publisher publisher = new Publisher();
            publisher.Subscribe(subscriber1);
            publisher.Subscribe(subscriber2);

            publisher.Notify("Test message");
            publisher.UnSubscribe(subscriber1);
            Console.WriteLine();
            publisher.Notify("Test message2");
        }
    }
}
