using Owin;

namespace KatanaIntro
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHelloWorld();
        }
    }
}
