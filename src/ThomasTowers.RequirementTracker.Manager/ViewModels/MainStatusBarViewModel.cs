using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace ThomasTowers.RetirementTracker.Manager.ViewModels
{
    internal class MainStatusBarViewModel : ObservableRecipient
    {
        private string? _message;

        public string? Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
    }
}
