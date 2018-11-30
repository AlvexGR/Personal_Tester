using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels.Controls
{
    public interface ICustomTestControlViewModel : IBaseViewModel
    {

    }

    class CustomTestControlViewModel : ReactiveObject, ICustomTestControlViewModel
    {

    }
}
