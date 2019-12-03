using System;
using EasyPrograming.Areas.Identity.Data;
using EasyProgramingCodex.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EasyPrograming.Areas.Identity.IdentityHostingStartup))]
namespace EasyPrograming.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EasyProgramingContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EasyProgramingContextConnection")));

                
            });
        }
    }
}