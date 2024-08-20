using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscribeExample
{
    class EventArgument : EventArgs
    {
        public string Message { get; set; }
        public bool subscribe { get; set; }
        public int Count { get; set; }

       
        public EventArgument(string Message)
        {
            this.Message = Message;
        }
        public EventArgument(bool subscribe) {
            this.subscribe = subscribe;
        }
        public EventArgument(int Count)
        {
            this.Count = Count;
        }
    }
}
