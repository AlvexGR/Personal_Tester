﻿using System;
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
using UI.Helpers;

namespace UI.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void whiteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageWindow messageWindow = new MessageWindow("Save successfully. Please restart the application for some settings to apply", "Save setting", DomainLibrary.Enums.MessageIconEnum.Success, DomainLibrary.Enums.MessageButtonEnum.OkCancel);
            messageWindow.Owner = GetWindow(this);
            messageWindow.ShowDialog();

            messageWindow = new MessageWindow("Hello World", "Nothing", DomainLibrary.Enums.MessageIconEnum.Warning, DomainLibrary.Enums.MessageButtonEnum.Ok);
            messageWindow.Owner = GetWindow(this);
            messageWindow.ShowDialog();

            messageWindow = new MessageWindow("Hello World", "Nothing", DomainLibrary.Enums.MessageIconEnum.Error, DomainLibrary.Enums.MessageButtonEnum.OkCancel);
            messageWindow.Owner = GetWindow(this);
            messageWindow.ShowDialog();
        }
    }
}
