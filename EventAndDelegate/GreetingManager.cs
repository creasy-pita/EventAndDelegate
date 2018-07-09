using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndDelegate
{
    class GreetingManager
    {
        public GreetingDelegate greetingDelegate;
        public void GreetPeople(string name)
        {
            greetingDelegate(name);
        }
    }
}
