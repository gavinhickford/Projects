using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using SIGN.Domain.Interfaces;
using SIGN.Data.EFCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SIGN
{
    public class Startup
    {
        private IHostingEnvironment _environment;
        private IConfigurationRoot _configuration;

        public Startup(IHostingEnvironment environment)
        {
            _environment = environment;
            var builder = new ConfigurationBuilder()
                .SetBasePath(_environment.ContentRootPath)
                .AddJsonFile("config.json");

            _configuration = builder.Build();
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton(_configuration);
            //services.AddDbContext<SIGNContext>();
            //services.AddEntityFramework(_configuration.GetConnectionString("DefaultConnection"));
            services.AddEntityFramework(_configuration["ConnectionStrings:SIGNContextConnectionString"]);
            services.AddScoped<ISIGNRepository, SIGNRepository>();
            services.AddTransient<SeedData>();

            //if (_environment.IsDevelopment())
            //{
                
            //}
            //else
            //{
            //    services.AddScoped<ISIGNRepository, SIGNRepository>();
            //}
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            ILoggerFactory loggerFactory,
            SeedData seed)
        {
            loggerFactory.AddConsole();
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index" }
                );
            });

            seed.EnsureSeedData();
        }
    }
}
