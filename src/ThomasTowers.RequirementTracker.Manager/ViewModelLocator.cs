using Microsoft.Extensions.DependencyInjection;
using ThomasTowers.RetirementTracker.Manager.ViewModels;

namespace ThomasTowers.RetirementTracker.Manager
{
    internal class ViewModelLocator
    {
        public MainViewModel MainViewModel => App.ServiceProvider.GetRequiredService<MainViewModel>();
        public MainMenuViewModel MainMenuViewModel => App.ServiceProvider.GetRequiredService<MainMenuViewModel>();
        public MainStatusBarViewModel MainStatusBarViewModel => App.ServiceProvider.GetRequiredService<MainStatusBarViewModel>();
    }
}
