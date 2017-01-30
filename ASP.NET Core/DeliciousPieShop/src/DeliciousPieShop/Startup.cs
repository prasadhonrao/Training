using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DeliciousPieShop.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DeliciousPieShop
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                           .SetBasePath(hostingEnvironment.ContentRootPath)
                           .AddJsonFile("appsettings.json")
                           .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                                         options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            //services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            //services.AddTransient<IPieRepository, MockPieRepository>();

            services.AddTransient<IPieRepository, PieRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //loggerFactory.AddConsole();

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            DbInitializer.Seed(app);
        }
    }
}
