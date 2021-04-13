using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using OperationDigger.Data;
using OperationDigger.Models;

namespace OperationDigger
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ebdbContext>(opts =>
            {
                opts.UseNpgsql(Configuration.GetConnectionString("OperationDiggerConnection"));
            });

            services.AddDbContext<OperationDiggerContext>(opts =>
            {
                opts.UseNpgsql(Configuration.GetConnectionString("OperationDiggerConnection"));
            });

            //var connectionString = Configuration.GetConnectionString("OperationDiggerConnection");
            ////MigrationManager.ThrowIfNotApplied(connectionString);
            //services.AddSingleton<DbConnection, NpgsqlConnection>(provider => new NpgsqlConnection(connectionString));

            //services.AddTransient<IUserStore<IdentityUser<long>>, UserStore>();
            //services.AddTransient<IRoleStore<IdentityRole<long>>, RoleStore>();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
