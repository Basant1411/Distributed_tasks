using System;
using System.Collections.Generic;
using System.Text;

namespace PublishSubscribeExample
{
    abstract class Publisher
    {
        public string Name { get; set; }
        public string message { get; set; }
        
    
        public event EventHandler<EventArgument> myEvent;
        public void Notify (string message)
        {
            EventArgument args = new EventArgument(message);
          
            if (myEvent != null)
                
                myEvent(this, args);
            }
        }
    }
class Facebook : PublishSubscribeExample.Publisher{
    public bool like { get; set; }
    public string comment { get; set; }
   
    }
class Google : PublishSubscribeExample.Publisher
{
    public string result{ get; set; }
    public int stars { get; set; }

}



