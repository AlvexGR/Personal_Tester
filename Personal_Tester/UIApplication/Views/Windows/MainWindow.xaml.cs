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
namespace UIApplication.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        private void whiteButton_Click(object sender, RoutedEventArgs e)
        {
            MessagePopupWindow messageWindow = new MessagePopupWindow("Save successfully. Please restart the application for some settings to apply", "Save setting", DomainLibrary.Enums.MessagePopupIconEnum.Success, DomainLibrary.Enums.MessagePopupButtonEnum.OkCancel)
            {
                Owner = GetWindow(this)
            };
            messageWindow.ShowDialog();

            messageWindow = new MessagePopupWindow("Hello World", "Nothing", DomainLibrary.Enums.MessagePopupIconEnum.Warning, DomainLibrary.Enums.MessagePopupButtonEnum.Ok);
            messageWindow.Owner = GetWindow(this);
            messageWindow.ShowDialog();

            messageWindow = new MessagePopupWindow("Hello World", "Nothing", DomainLibrary.Enums.MessagePopupIconEnum.Error, DomainLibrary.Enums.MessagePopupButtonEnum.OkCancel);
            messageWindow.Owner = GetWindow(this);
            messageWindow.ShowDialog();

        }

        #region Events
        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // setup view
            
        }
        #endregion
    }
}
