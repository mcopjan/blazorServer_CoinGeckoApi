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
using CoinGeckoApi_Blazor.Services;

namespace CoinGeckoApi_Blazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddHttpClient<ExchangesService>(client =>
            {
                client.BaseAddress = new Uri("https://coingecko.p.rapidapi.com");
                client.DefaultRequestHeaders.Add("x-rapidapi-key", "498575e1f1mshf64bc786951dff8p151f0ejsn1847f4ae8ae9");
                client.DefaultRequestHeaders.Add("x-rapidapi-host", "coingecko.p.rapidapi.com");
            });

            services.AddHttpClient<CoinsService>(client =>
            {
                client.BaseAddress = new Uri("https://coingecko.p.rapidapi.com");
                client.DefaultRequestHeaders.Add("x-rapidapi-key", "498575e1f1mshf64bc786951dff8p151f0ejsn1847f4ae8ae9");
                client.DefaultRequestHeaders.Add("x-rapidapi-host", "coingecko.p.rapidapi.com");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
        }
    }
}
