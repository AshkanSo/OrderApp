using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace OrderApp
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider;

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=.;Database=OrderApp;Trusted_Connection=True;TrustServerCertificate=True"));
            
            services.AddTransient<Form1>();
            services.AddTransient<RegisterOrder>();

            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }
    }
}
