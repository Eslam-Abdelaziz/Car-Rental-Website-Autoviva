using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Data.Configurations
{
    public static class DbServiceSetup
    {
        public static void RegisterIdentity(this IServiceCollection app, ConfigurationManager configuration) 
        {


            string connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
 
            app.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString))
                .AddIdentity<User, IdentityRole>(option=> option.SignIn.RequireConfirmedEmail = true)
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            app.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/auth/login";
                options.LogoutPath = $"/auth/signout";
                options.AccessDeniedPath = $"/auth/login";
			});

        }
    }
}
