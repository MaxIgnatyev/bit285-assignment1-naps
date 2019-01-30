using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace bit285_assignment1_naps
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<bit285assignment1naps.Models.User>();
            services.AddTransient<bit285assignment1naps.Models.PasswordSuggestionService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            //app.UseFileServer();
            app.UseMvc(routes =>
            {
                routes.MapRoute("Default",
                        "{controller=Naps}/{action=AccountInfo}");
                //routes.MapRoute(
                //name: "default",
                //template: "{controller}/{action}",
                //defaults: new { action = "Index" });
            });

        }
    }
}
