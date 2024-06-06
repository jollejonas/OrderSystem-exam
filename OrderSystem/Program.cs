using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderSystem.Data;
using OrderSystem.Views;
using OrderSystem.Controllers;
using OrderSystem.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OrderSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    var basePath = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName;
                    config.SetBasePath(basePath);
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    var configuration = hostContext.Configuration;
                    services.AddDbContext<OrderSystemContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("OrderSystemContext")));
                    services.AddTransient<StartView>();
                    services.AddTransient<CreateView>();
                    services.AddTransient<MenuView>();
                    services.AddTransient<OrderView>();
                    services.AddTransient<MainForm>();
                    services.AddTransient<UserController>();
                    services.AddTransient<OrderController>();
                    services.AddTransient<MachineController>();
                    services.AddTransient<Navigator>();
                });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                DataInitializer.Initialize(services);
                var navigator = services.GetRequiredService<Navigator>();

                var mainForm = services.GetRequiredService<MainForm>();
                navigator.Initialize(mainForm);
                var startView = services.GetRequiredService<StartView>();
                Application.Run(startView);
            }
        }
    }
}