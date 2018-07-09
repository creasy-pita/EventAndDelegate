using System;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetPeople("creasy pita", EnglishGreeting);
            GreetPeople("卢俊强", ChineseGreeting);

            Console.ReadLine();
        }

        static void GreetPeople(string lan, string name)
        {
            if (lan == "en")
            {
                EnglishGreeting(name);
            }
            else if (lan =="cn")
            {
                ChineseGreeting(name);
            }
        }

        static void GreetPeople(string name, GreetingDelegate greetingDelegate)
        {
            greetingDelegate(name);
        }

        static void EnglishGreeting(string name)
        {
            Console.Write(" morning ," + name);
        }

        static void ChineseGreeting(string name)
        {
            Console.Write(" 早上好 ," + name);
        }
    }
}
