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
using AutoMapper;
using SIGN.ViewModels;
using SIGN.Domain.Classes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

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
            services.AddMvc(config =>
            {
                if (_environment.IsProduction())
                {
                    config.Filters.Add(new RequireHttpsAttribute());
                }
            });

            services.AddSingleton(_configuration);
            //services.AddDbContext<SIGNContext>();
            //services.AddEntityFramework(_configuration.GetConnectionString("DefaultConnection"));
            services.AddEntityFramework(_configuration["ConnectionStrings:SIGNContextConnectionString"]);
            services.AddScoped<ISIGNRepository, SIGNRepository>();
            services.AddTransient<SeedData>();
            services.AddLogging();
            services.AddIdentity<SIGNUser, IdentityRole>(config =>
            {
                config.User.RequireUniqueEmail = true;
                config.Password.RequiredLength = 8;
                config.Cookies.ApplicationCookie.LoginPath = "/Auth/Login";
            })
            .AddEntityFrameworkStores<SIGNContext>();

            //if (_environment.IsDevelopment())
            //{
                
            //}
            //else
            //{
            //    services.AddScoped<ISIGNRepository, SIGNRepository>();
            //}
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory,
            SeedData seed)
        {
            SetupMappings();

            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
                loggerFactory.AddDebug(LogLevel.Information);
            }
            else
            {
                loggerFactory.AddDebug(LogLevel.Error);
            }

            app.UseStaticFiles();
            app.UseIdentity();
            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index" }
                );
            });

            await seed.EnsureSeedData();
        }

        private static void SetupMappings()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<GuidelineViewModel, Guideline>().ReverseMap();
                config.CreateMap<AssessmentViewModel, Assessment>().ReverseMap();
                config.CreateMap<StepViewModel, Step>().ReverseMap();
            });
        }
    }
}
