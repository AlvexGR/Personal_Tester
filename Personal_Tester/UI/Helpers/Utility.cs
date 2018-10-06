using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UI.Helpers
{
    public static class Utility
    {
        public static App GetApp()
        {
            return (App)Application.Current;
        }
    }
}
