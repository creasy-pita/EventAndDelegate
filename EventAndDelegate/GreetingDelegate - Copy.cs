using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndDelegate
{
    class GreetingManager
    {
        public void GreetPeople(string name,GreetingDelegate greetingDelegate)
        {
            greetingDelegate(name);
        }
    }
}
