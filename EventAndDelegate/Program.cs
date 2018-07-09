using System;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //GreetingDelegate delegate1 = ChineseGreeting;
            //delegate1 += EnglishGreeting;//多个参数链
            //GreetingManager gm = new GreetingManager();
            //gm.MakeGreet += delegate1;
            //gm.GreetPeople("CreasyPita1231");

            Heater heater = new Heater();
            heater.BoilWater();

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
            Console.WriteLine("Morning ," + name);
        }

        static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好," + name);
        }
    }
}
