using System;

namespace PublishSubscribeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook pub1 = new Facebook();
            Google pub2 = new Google();
           pub1.Name = "Amany";
           pub2.Name = "basant";
            pub1.comment = "very well App";
            pub2.result = "1000 result";
            pub1.message = "wellcome";
            pub2.stars = 5;
            Subscriber sub1 = new Subscriber();
            Subscriber sub2 = new Subscriber();
            Subscriber sub3 = new Subscriber();
            Subscriber sub4 = new Subscriber();

          sub1.Subscribe(pub1);
           sub2.Subscribe(pub2);
           sub3.Subscribe(pub1);
           sub4.Subscribe(pub2);

            pub1.Notify("This is the first message!");
            pub2.Notify("This is the first message!");

            sub2.Unsubscribe(pub1);
            pub1.Notify("This message will not show up to sub2!");
        }
    }
}
