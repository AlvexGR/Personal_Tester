﻿using Core.ViewModels.Windows;
using DomainLibrary.Enums;
using DomainLibrary.Interfaces;
using DomainLibrary.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace UIApplication.Views.Windows
{
    /// <summary>
    /// Interaction logic for MessageWindow.xaml
    /// </summary>
    public partial class MessagePopupWindow : Window, IViewFor<IMessageWindowViewModel>
    {
        #region Properties
        public static readonly DependencyProperty ViewModelProperty = 
            DependencyProperty.Register(nameof(ViewModel), typeof(IMessageWindowViewModel), typeof(MessagePopupWindow));
        public IMessageWindowViewModel ViewModel
        {
            get => GetValue(ViewModelProperty) as IMessageWindowViewModel;
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = value as IMessageWindowViewModel;
        }

        // List of icon
        private List<string> imageSource;

        private IMessagePopupModel messageModel;
        #endregion

        #region Constructor
        public MessagePopupWindow(string message, string title, MessagePopupIconEnum icon, MessagePopupButtonEnum button)
        {
            InitializeComponent();
            SetupView();
            messageModel = new MessagePopupModel(message, title, icon, button);
            ViewModel = new MessagePopupWindowViewModel();
            imageSource = new List<string>()
            {
                "pack://application:,,,/Resources/Images/MessageResult/Warning_0.png",
                "pack://application:,,,/Resources/Images/MessageResult/Success_0.png",
                "pack://application:,,,/Resources/Images/MessageResult/Error_0.png"
            };

            this.WhenActivated(d =>
            {
                Binding(d);
            });
        }
        #endregion

        #region Binding
        private void Binding(Action<IDisposable> d)
        {
            d(this.BindCommand(ViewModel, vm => vm.OkCommand, v => v.okButton));
            d(ViewModel.OkCommand.Subscribe(x =>
            {
                Close();
            }));

            d(this.BindCommand(ViewModel, vm => vm.CancelCommand, v => v.cancelButton));
            d(ViewModel.CancelCommand.Subscribe(x =>
            {
                Close();
            }));
        }
        #endregion
        
        private void SetupView()
        {
            if (messageModel.Button == MessagePopupButtonEnum.OkCancel)
            {
                cancelButton.Visibility = Visibility.Visible;
            }
            messageTextBlock.Text = messageModel.Message;
            titleTextBlock.Text = messageModel.Title;
            iconMessageImage.Source = new BitmapImage(new Uri(imageSource[Convert.ToInt32(messageModel.Icon)], UriKind.Absolute));
        }
    }
}