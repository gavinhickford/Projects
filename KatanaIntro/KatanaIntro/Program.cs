﻿using Microsoft.Owin.Hosting;
using Owin;
using System;

namespace KatanaIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started");
                Console.ReadKey();
                Console.WriteLine("Stopping");
            }
        }

    }
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage();
//            app.Run(ctx => ctx.Response.WriteAsync("<h1>Hello World</h1>"));
        }

    }
}