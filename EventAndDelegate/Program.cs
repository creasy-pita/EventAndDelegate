using System;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetPeople("en", "jesse");

            Console.ReadLine();
        }

        static void GreetPeople(string lan, string name)
        {
            if (lan == "en")
            {
                EnlishGreeting(name);
            }
            else
            {
                ChineseGreeting(name);
            }
        }

        static void EnlishGreeting(string name)
        {
            Console.Write(" morning ," + name);
        }

        static void ChineseGreeting(string name)
        {
            Console.Write(" 早上好 ," + name);
        }
    }
}
