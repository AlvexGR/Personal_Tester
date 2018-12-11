﻿using Core.ViewModels.Controls;
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

namespace UIApplication.Views.Controls
{
    /// <summary>
    /// Interaction logic for SettingControl.xaml
    /// </summary>
    public partial class SettingControl : UserControl, IViewFor<ISettingControlViewModel>
    {
        #region Constructor

        public SettingControl()
        {
            InitializeComponent();
        }

        #endregion


        #region Properties

        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(ISettingControlViewModel), typeof(SettingControl));

        public ISettingControlViewModel ViewModel
        {
            get => GetValue(ViewModelProperty) as ISettingControlViewModel;
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as ISettingControlViewModel;
        }

        #endregion
    }
}