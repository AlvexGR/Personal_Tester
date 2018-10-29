using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels.Windows
{
    public interface IMainWindowViewModel : IBaseViewModel
    {

    }

    public class MainWindowViewModel : ReactiveObject, IMainWindowViewModel
    {
        public MainWindowViewModel()
        {

        }
    }
}
