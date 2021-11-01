using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ThomasTowers.RetirementTracker.Manager.ViewModels
{
    internal class AccountViewModel : ObservableValidator
    {
        private string? _name;

        [MinLength(4)]
        [MaxLength(20)]
        [Required]
        public string? Name
        {
            get => _name;
            set => SetProperty(ref _name, value, validate: true);
        }
    }
}
