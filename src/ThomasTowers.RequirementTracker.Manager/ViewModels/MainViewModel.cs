using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ThomasTowers.RetirementTracker.Manager.ViewModels
{
    internal class MainViewModel : ObservableRecipient
    {
        public ObservableCollection<AccountViewModel> Accounts { get; } = new ObservableCollection<AccountViewModel>();
    }
}
