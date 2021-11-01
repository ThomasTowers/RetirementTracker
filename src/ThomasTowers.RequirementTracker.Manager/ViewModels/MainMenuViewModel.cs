using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace ThomasTowers.RetirementTracker.Manager.ViewModels
{
    internal class MainMenuViewModel : ObservableRecipient
    {
        public ICommand CloseCommand { get; } = new RelayCommand(() => Application.Current.Shutdown());
        public ICommand ShowAboutCommand { get; } = new RelayCommand(() => MessageBox.Show(Application.Current.MainWindow.Title, "About"));
    }
}
