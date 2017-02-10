using System;

namespace ObserverDemo
{
    public class Doer
    {
        private string _data;
        public event EventHandler<string> AfterDoSomething;
        public event EventHandler<Tuple<string, string>> AfterDoMore;

        public void DoSomething(string data)
        {
            _data = data;
            Console.WriteLine($"Doing something with {data}");
            OnAfterDoSomething(_data);
        }

        public void DoMore(string appendData)
        {
            _data += appendData;
            OnAfterDoMore(_data, appendData);
        }

        private void OnAfterDoSomething(string data)
        {
            AfterDoSomething?.Invoke(this, data);
        }

        private void OnAfterDoMore(string completeData, string appendData)
        {
            AfterDoMore?.Invoke(this, Tuple.Create(completeData, appendData));
        }
    }
}
