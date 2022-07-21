using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.MahApps;

namespace ATM_Software.Common.Dialogs
{
    public static class ErrorContentDialog
    {
        public static void ShowDialog(string title, string ErrorMessage)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = title;
            dialog.Content = ErrorMessage;
            dialog.CloseButtonText = "OK";
            dialog.ShowAsync();
        }
    }
}
