using Microsoft.Extensions.DependencyInjection;
using ThomasTowers.RequirementTracker.Manager.ViewModels;

namespace ThomasTowers.RequirementTracker.Manager
{
    internal class ViewModelLocator
    {
        public MainViewModel MainViewModel
                => App.ServiceProvider.GetRequiredService<MainViewModel>();
    }
}
