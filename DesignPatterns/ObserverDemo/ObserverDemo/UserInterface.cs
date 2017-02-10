using System;

namespace ObserverDemo
{
    public class UserInterface
    {
        public void AfterDoSomething(object sender, string data)
        {
            Console.WriteLine($"Hey user, look at {data.ToUpper()}.");
        }
    }
}
