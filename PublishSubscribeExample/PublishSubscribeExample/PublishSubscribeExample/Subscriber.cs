using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscribeExample
{
    class Subscriber
    {
        public void Subscribe(Publisher pub)
        {
            pub.myEvent += Update;
        }
        public void Unsubscribe(Publisher pub)
        {
            pub.myEvent -= Update;
        }
        public void Update(object sender, EventArgument args)
        {
            Publisher pub = (Publisher) sender;
            Console.WriteLine(pub.Name + " Send a message: " + args.Message);
        }
    }
}
