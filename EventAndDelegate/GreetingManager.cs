using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndDelegate
{
    class GreetingManager
    {
        public event GreetingDelegate MakeGreet;
        public void GreetPeople(string name)
        {
            MakeGreet(name);
        }
    }
}
