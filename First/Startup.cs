using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("/hello", async context =>
                {
                    await context.Response.WriteAsync("Hello nice and friendly people!");
                });
                endpoints.MapGet("/hi/{name}", async context =>
                {
                    var name = context.Request.RouteValues["name"];
                    await context.Response.WriteAsync($"Hi {name}");
                });
                endpoints.MapGet("/boom", async context =>
                {
                    throw new Exception("bum");
                });
                endpoints.MapGet("/hi2", async context =>
                {
                    var name = context.Request.Query["name"];
                    await context.Response.WriteAsync($"Hi {name}");
                });
                endpoints.MapGet("/add/{a:int}/{b:int}", async context =>
                {
                    var a = Convert.ToInt32(context.Request.RouteValues["a"]);
                    var b = Convert.ToInt32(context.Request.RouteValues["b"]);
                    var c = a + b;
                    await context.Response.WriteAsync($"<p>{a}+{b}={c}</p>");
                });
                endpoints.MapRazorPages();
            });
        }
    }
}
