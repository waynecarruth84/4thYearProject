using System;
using GamingAnalytics.Areas.Identity.Data;
using GamingAnalytics.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GamingAnalytics.Areas.Identity.IdentityHostingStartup))]
namespace GamingAnalytics.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GamingAnalyticsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GamingAnalyticsContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<GamingAnalyticsContext>();
            });
        }
    }
}