using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DCFingerprintDBClass;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace DCFingerprintAPIs
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IHostingEnvironment Env { get; set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            string conn;
            if (Env.IsDevelopment())
            {
                conn = @"Server =.\SQLEXPRESS01; Database=BSSLSYS_ITF; Trusted_Connection=True;";
            }
            else
            {
                //TODO:update to server connection
                conn = @"Data Source=WIN2016\BSSLDATAENGIN;Initial Catalog=BSSLSYS_ITFDEMO;User ID=sa;Password=Bssl2019**;Integrated Security=False;
                  Trusted_Connection=True;ConnectRetryCount=0;MultipleActiveResultSets=true";
            }

            services.AddDbContext<bsslsys_itfContext>(options => options.UseSqlServer(conn, b => b.MigrationsAssembly("DCFingerprintAPIs")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Fingerprint API Docs", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
