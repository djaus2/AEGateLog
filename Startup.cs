using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorQRCode.Data;

namespace BlazorQRCode
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            System.Diagnostics.Debug.WriteLine("1.1");
            Configuration = configuration;
            System.Diagnostics.Debug.WriteLine("1.10");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            System.Diagnostics.Debug.WriteLine("2.1");
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<AthleteService>();
            services.AddSingleton<HomeController>();
            services.AddHttpContextAccessor();
            System.Diagnostics.Debug.WriteLine("2.10");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            System.Diagnostics.Debug.WriteLine("3.1");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
            System.Diagnostics.Debug.WriteLine("3.10");
        }
    }
}
