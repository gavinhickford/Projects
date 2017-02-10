using System;

namespace ObserverDemo
{
    public class Logger
    {
        public void AfterDoSomething(object sender, string data)
        {
            Console.WriteLine($"Hey user, look at {data.ToUpper()}.");
        }

        public void AfterDoMore(object sender, Tuple<string, string> data)
        {
            Console.WriteLine($"Logging Do more - {data.Item1.ToUpper()}, (appended data : {data.Item2.ToUpper()})");
        }
    }
}
