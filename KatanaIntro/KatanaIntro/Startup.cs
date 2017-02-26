using Owin;
using System;

namespace KatanaIntro
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use(async (environment, next) =>
            {
                foreach (var pair in environment.Environment)
                {
                    Console.WriteLine($"{pair.Key}:{pair.Value}");
                }

                await next();
            });

            app.Use(async (environment, next) =>
            {
                Console.WriteLine($"Requesting: {environment.Request.Path}");

                await next();

                Console.WriteLine($"Response: {environment.Response.StatusCode}");
            });

            app.UseHelloWorld();
        }
    }
}
