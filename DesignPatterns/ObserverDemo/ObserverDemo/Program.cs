using System;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var doer = new Doer();
            var userInterface = new UserInterface();
            var logger = new Logger();

            doer.AfterDoSomething += userInterface.AfterDoSomething;
            doer.AfterDoSomething += logger.AfterDoSomething;
            doer.AfterDoMore += logger.AfterDoMore;

            doer.DoSomething("my data");
            doer.DoMore("appended data");
            Console.ReadLine();
        }
    }
}
