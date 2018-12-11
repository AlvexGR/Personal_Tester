using DomainLibrary.Interfaces;
using DomainLibrary.Models;
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
using System.Windows.Shapes;
using UIApplication.Helpers;
using DomainLibrary;
using Core.ViewModels.Windows;
using ReactiveUI;
using UIApplication.Views.Controls;

namespace UIApplication.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewFor<IMainWindowViewModel>
    {
        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            TestCaseControl tcc = new TestCaseControl();
            
        }
        #endregion


        #region Properties

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(IMainWindowViewModel), typeof(MainWindow));

        public IMainWindowViewModel ViewModel
        {
            get => GetValue(ViewModelProperty) as IMainWindowViewModel;
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as IMainWindowViewModel;
        }

        #endregion
    }
}
