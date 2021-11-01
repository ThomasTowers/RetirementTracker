using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomasTowers.RetirementTracker
{
    public interface IActivable
    {
        Task ActivateAsync(object parameter);
    }
}
