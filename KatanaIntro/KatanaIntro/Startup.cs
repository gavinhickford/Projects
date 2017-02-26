using Owin;
using System;
using System.Web.Http;

namespace KatanaIntro
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Use(async (environment, next) =>
            //{
            //    foreach (var pair in environment.Environment)
            //    {
            //        Console.WriteLine($"{pair.Key}:{pair.Value}");
            //    }

            //    await next();
            //});

            app.Use(async (environment, next) =>
            {
                Console.WriteLine($"Requesting: {environment.Request.Path}");

                await next();

                Console.WriteLine($"Response: {environment.Response.StatusCode}");
            });

            ConfigureWebApi(app);

            app.UseHelloWorld();
        }

        private void ConfigureWebApi(IAppBuilder app)
        {
            // To configure the web api in a self hosted app,create new HttpApplication in SYstem.Web.Http
            // This controls routing rules, serialisers and formatters.
            // We need it to configure routs
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi", 
                "api/{controller}/{id}", 
                new {id = RouteParameter.Optional});
            app.UseWebApi(config);
        }
    }
}
