using BudgetApp.UI.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BudgetApp.UI
{
    public class Application
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(serviceCollection => serviceCollection.AddScoped<MainWindow>())
                .Build();

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(host.Services.GetRequiredService<MainWindow>());
        }
    }
}
