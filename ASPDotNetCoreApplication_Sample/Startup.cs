using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotNetCoreApplication_Sample.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ASPDotNetCoreApplication_Sample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddScoped<IRestaurentData, InMemoryRestaurentData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter service, ILogger<Startup> logger)
        {
            //app.Use(next =>
            //    {

            //        return async context =>
            //        {
            //            logger.LogInformation("Request Incoming");
            //            if (context.Request.Path.StartsWithSegments("/mym"))
            //            {
            //                await context.Response.WriteAsync("Hit!!!");
            //                logger.LogInformation("Request Handled");
            //            }
            //            else
            //            {
            //                await next(context);
            //                logger.LogInformation("Request outgoing");
            //            }
            //        };
            //    });

            //app.UseWelcomePage(new WelcomePageOptions
            //{
            //    Path = "/wp"
            //}
            //);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseFileServer();
            //app.UseDefaultFiles();

            app.UseStaticFiles();
            app.UseMvc(configureRoute);
            //app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"{service.NewMethod()}: {env.EnvironmentName}");
            });
        }

        private void configureRoute(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Dafault","{controller}/{action}");
        }
    }
}
