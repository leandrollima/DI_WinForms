using Microsoft.Extensions.DependencyInjection;
using POC.EFCore.Configuration;

namespace POC.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            string connection = "{YOUR_STRING_CONNECTION}";

            services.AddAppDbContext(connection);
            services.AddScoped<Form1>();
        }
    }
}