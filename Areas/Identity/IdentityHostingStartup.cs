using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SSD_LAB_1.Data;
using SSD_LAB_1.Models;

[assembly: HostingStartup(typeof(SSD_LAB_1.Areas.Identity.IdentityHostingStartup))]
namespace SSD_LAB_1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<ApplicationDbContext>(options =>
               // options.UseSqlServer(
                    //context.Configuration.GetConnectionString("ApplicationDBContextConnection")));

                //services.AddDefaultIdentity<ApplicationUser>()
                    //.AddEntityFrameworkStores<ApplicationDbContext>()
                //.AddRoles<IdentityRole>();
            });
        }
    }
}