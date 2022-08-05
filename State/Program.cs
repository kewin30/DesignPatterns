using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            context.EjectCard();

            context.InsertCard();

            context.InsertPin(1111);
            context.InsertCard();
            context.InsertPin(888);

            context.WithdrawCash(2000);
            context.InsertCard();
        }
    }
}
