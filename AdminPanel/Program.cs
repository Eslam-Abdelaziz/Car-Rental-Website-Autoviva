using AdminPanel.Forms;
using AdminPanel.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace AdminPanel
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            
            Application.Run(ServiceProvider.GetRequiredService<Forms.Auth.Frm_Login>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddSingleton<Frm_Main>();
                    services.AddSingleton<Forms.Auth.Frm_Login>();
                    services.AddSingleton<Forms.User.Frm_List>() ;
                    services.AddSingleton<Forms.Brand.Frm_List>();
                    services.AddSingleton<Forms.Branch.Frm_List>();
                    services.AddSingleton<Forms.Color.Frm_List>();
                    services.AddSingleton<Forms.Car.Frm_List>();
                    services.AddSingleton<Forms.Rental.Frm_List>();
                    services.AddSingleton<Forms.Frm_Statistics>();

                    //https://api-autoviva.azurewebsites.net
                    services.AddSingleton(_ => new ConnectionService("https://localhost:7015/"));
                    services.AddSingleton<AuthService>();
                    services.AddSingleton<UserService>();
                    services.AddSingleton<BrandService>();
                    services.AddSingleton<BranchService>();
                    services.AddSingleton<ColorService>();
                    services.AddSingleton<CarService>();
                    services.AddSingleton<ModelService>();
                    services.AddSingleton<RentalService>();

                    services.AddAutoMapper(Assembly.GetExecutingAssembly());

                });
        }
    }
}
