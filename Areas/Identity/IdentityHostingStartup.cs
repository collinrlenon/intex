using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OperationDigger.Areas.Identity.Data;
using OperationDigger.Data;

[assembly: HostingStartup(typeof(OperationDigger.Areas.Identity.IdentityHostingStartup))]
namespace OperationDigger.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<OperationDiggerContext>(options =>
                //    options.UseNpgsql(Configuration.GetConnectionString("OperationDiggerConnection"));

                //services.AddDefaultIdentity<OperationDiggerUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<OperationDiggerContext>();
            });
        }
    }
}