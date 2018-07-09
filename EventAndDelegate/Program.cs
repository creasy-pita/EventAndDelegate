using System;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingDelegate delegate1 = new GreetingDelegate(EnglishGreeting);// 创建委托类型变量的一种写法  new GreetingDelegate
            GreetingDelegate delegate2 = new GreetingDelegate(ChineseGreeting);
            //GreetingDelegate delegate1, delegate2;
            //delegate1 = EnglishGreeting;//委托类型 和 EnglishGreeting 类型 方法定义上等价可以直接赋值；
            //delegate2 = ChineseGreeting;
            GreetPeople("creasypita", delegate1);
            GreetPeople("卢俊强", delegate2);

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
