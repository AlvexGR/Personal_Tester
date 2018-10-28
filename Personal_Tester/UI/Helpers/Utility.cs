using DomainLibrary.Enums;
using DomainLibrary.Interfaces;
using DomainLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UI.Views.Windows;

namespace UI.Helpers
{
    /// <summary>
    /// Store utility global properties and methods
    /// </summary>
    public static class Utility
    {
        #region Properties
        /// <summary>
        /// Result from the MessageWindow that user chose
        /// </summary>
        public static bool MessageResult;

        /// <summary>
        /// Current language
        /// </summary>
        public static LanguagesEnum language;
        #endregion

        #region Methods
        /// <summary>
        /// Get the current application object
        /// </summary>
        public static App GetApp()
        {
            return (App)Application.Current;
        }
        #endregion
    }
}
