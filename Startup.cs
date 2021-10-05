using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace cd_c_portfolioII
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // ADD THIS LINE (makes MVC service available to rest of application, without it we can not build an MVC application, still need to 'tell' app to use MVC under 'Configure' - see below)
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // ADD THIS LINE (tells app to use Mvc, after making it available above in 'Configure Services')
            app.UseMvc();
            // NOW CAN COMMENT OUT BELOW, (we are using Mvc instead?)
            // app.UseRouting();
            
            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapGet("/", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello World!");
            //     });
            // });
        }
        // ADD THESE LINES -->
        public Startup(IWebHostEnvironment env)
        {
            System.Console.WriteLine(env.ContentRootPath);
            System.Console.WriteLine(env.IsDevelopment());
        }
    }
}
