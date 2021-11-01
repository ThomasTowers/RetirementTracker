using System.ComponentModel;
using ThomasTowers.RetirementTracker.Manager.ViewModels;
using Xunit;

namespace ThomasTowers.RetirementTracker.Manager.UnitTests.ViewModels
{
    public class AccountViewModelUnitTests
    {
        [Fact]
        public void TestValidation()
        {
            var model = new AccountViewModel();

            var args = new List<PropertyChangedEventArgs>();

            model.PropertyChanged += (s, e) => args.Add(e);

            Assert.False(model.HasErrors);

            model.Name = "No";

            // Verify that errors were correctly reported as changed, and that all the relevant
            // properties were broadcast as well (both the changed property and HasErrors). We need
            // this last one to raise notifications too so that users can bind to that in the UI.
            Assert.True(model.HasErrors);
            Assert.Equal(2, args.Count);
            Assert.Equal(nameof(AccountViewModel.Name), args[0].PropertyName);
            Assert.Equal(nameof(INotifyDataErrorInfo.HasErrors), args[1].PropertyName);

            model.Name = "Valid";

            Assert.False(model.HasErrors);
            Assert.Equal(4, args.Count);
            Assert.Equal(nameof(AccountViewModel.Name), args[2].PropertyName);
            Assert.Equal(nameof(INotifyDataErrorInfo.HasErrors), args[3].PropertyName);
        }
    }
}
