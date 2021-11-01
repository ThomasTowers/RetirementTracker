using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using ThomasTowers.RetirementTracker.Manager.ViewModels;

namespace ThomasTowers.RetirementTracker.Manager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        internal static IServiceProvider ServiceProvider { get; private set; } = null!;

        public App()
        {
            _host = new HostBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<MainViewModel>();
                    services.AddSingleton<MainMenuViewModel>();
                    services.AddSingleton<MainStatusBarViewModel>();
                    services.AddSingleton<MainWindow>();
                })
                .Build();

            ServiceProvider = _host.Services;
        }

        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            await _host.StartAsync();

            var mainWindow = _host.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

        private async void Application_Exit(object sender, ExitEventArgs e)
        {
            using (_host)
            {
                await _host.StopAsync(TimeSpan.FromSeconds(5));
            }
        }
    }
}
