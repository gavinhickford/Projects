using Owin;

namespace KatanaIntro
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<HelloWorldComponent>();
            //app.UseWelcomePage();
            //            app.Run(ctx => ctx.Response.WriteAsync("<h1>Hello World</h1>"));
        }
    }
}
