using CarRental.Application.Contracts;
using CarRental.Application.Contracts.Entities;
using CarRental.Application.Repositories;
using CarRental.Application.Repositories.Entities;
using CarRental.Data.Configurations;
using CarRental.Data.Models;
using Stripe;

namespace CarRental.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();


            builder.Services.RegisterIdentity(builder.Configuration);



            builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("EmailSettings"));


			builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			builder.Services.AddScoped<ICarImageService, CarImageService>();
            builder.Services.AddScoped<IBrandService, BrandService>();
            builder.Services.AddScoped<IBranchService, BranchService>();
            builder.Services.AddScoped<ICarService, CarService>();
			builder.Services.AddScoped<ICarImageService, CarImageService>();
			builder.Services.AddScoped<IFavouritesService, FavouriteService>();
			builder.Services.AddTransient<IEmailSender, EmailSender>();
			builder.Services.AddTransient<IModelService, ModelService>();
            builder.Services.AddScoped<IRentalService, RentalService>();
            builder.Services.AddScoped<IPaymentService, PaymentService>();
            builder.Services.AddScoped<IAddressService, AddressService>();

            StripeConfiguration.ApiKey = "sk_test_51NQayrCETvsw59btJLMAdM67dtjTswpsFtnjOpEfgqnkBJ1oRLTWpQm9RdHwxXI5jGQozA5kovva3za1hCoSdO3y00xwleaCZY";

            builder.Services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = builder.Configuration["GoogleSettings:ClientId"];
                googleOptions.ClientSecret = builder.Configuration["GoogleSettings:ClientSecret"];
            });

            builder.Services.AddAuthentication().AddFacebook(facebookOptions => 
            {
                facebookOptions.ClientId = builder.Configuration["FbSettings:ClientId"];
                facebookOptions.ClientSecret = builder.Configuration["FbSettings:ClientSecret"];
            });


            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}