using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Publisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void UnSubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        public void Notify(string context)
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Update(context);
            }
        }
    }
}
