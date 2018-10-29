using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.ViewModels.Controls;

namespace UI.Views.Controls
{
    /// <summary>
    /// Interaction logic for SideBarControl.xaml
    /// </summary>
    public partial class SideBarControl : UserControl, IViewFor<ISideBarControlViewModel>
    {
        #region Properties
        public static readonly DependencyProperty ViewModelProperty = 
            DependencyProperty.Register(nameof(ViewModel), typeof(ISideBarControlViewModel), typeof(SideBarControl));

        public ISideBarControlViewModel ViewModel
        {
            get => GetValue(ViewModelProperty) as ISideBarControlViewModel;
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as ISideBarControlViewModel;
        }
        #endregion

        #region Constructor
        public SideBarControl()
        {
            InitializeComponent();
            ViewModel = new SideBarControlViewModel();
            this.WhenActivated(d =>
            {
                Binding(d);
            });
        }
        #endregion

        #region Binding
        private void Binding(Action<IDisposable> d)
        {
            d(this.BindCommand(ViewModel, vm => vm.CustomTestCommand, v => v.customTestButton));
            d(ViewModel.CustomTestCommand.Subscribe(x =>
            {
                // Later
            }));

            d(this.BindCommand(ViewModel, vm => vm.SolutionTestCommand, v => v.solutionTestButton));
            d(ViewModel.SolutionTestCommand.Subscribe(x =>
            {
                // Later
            }));

            d(this.BindCommand(ViewModel, vm => vm.TreeCodeCommand, v => v.treeCodeButton));
            d(ViewModel.TreeCodeCommand.Subscribe(x =>
            {
                // Later
            }));

            d(this.BindCommand(ViewModel, vm => vm.SettingCommand, v => v.settingButton));
            d(ViewModel.SettingCommand.Subscribe(x =>
            {
                // Later
            }));
        }
        #endregion
    }
}
