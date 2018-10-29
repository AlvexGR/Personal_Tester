using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels.Controls
{
    public interface ISideBarControlViewModel : IBaseViewModel
    {
        /// <summary>
        /// Open Custom Test
        /// </summary>
        ReactiveCommand<Unit, Unit> CustomTestCommand { get; }

        /// <summary>
        /// Open Solution Test
        /// </summary>
        ReactiveCommand<Unit, Unit> SolutionTestCommand { get; }

        /// <summary>
        /// Open Tree Code
        /// </summary>
        ReactiveCommand<Unit, Unit> TreeCodeCommand { get; }

        /// <summary>
        /// Open Settings
        /// </summary>
        ReactiveCommand<Unit, Unit> SettingCommand { get; }
    }

    public class SideBarControlViewModel : ReactiveObject, ISideBarControlViewModel
    {
        public ReactiveCommand<Unit, Unit> CustomTestCommand { get; }
        public ReactiveCommand<Unit, Unit> SolutionTestCommand { get; }
        public ReactiveCommand<Unit, Unit> TreeCodeCommand { get; }
        public ReactiveCommand<Unit, Unit> SettingCommand { get; }

        public SideBarControlViewModel()
        {
            CustomTestCommand = ReactiveCommand.Create(() => { });
            SolutionTestCommand = ReactiveCommand.Create(() => { });
            TreeCodeCommand = ReactiveCommand.Create(() => { });
            SettingCommand = ReactiveCommand.Create(() => { });
        }
    }
}
