using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace KatanaIntro
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    public class HelloWorldComponent
    {
        private readonly AppFunc _next;

        public HelloWorldComponent(AppFunc next)
        {
            _next = next;
        }
        public Task Invoke(IDictionary<string, object> environment)
        {
            var response = environment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                return writer.WriteAsync("<h1>Hello</h1>");
            }

//            await _next(environment);
        }
    }
}
