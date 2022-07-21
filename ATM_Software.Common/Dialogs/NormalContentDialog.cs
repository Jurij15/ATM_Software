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
    public static class NormalContentDialog
    {
        public static void ShowDialog(string title, string content, string OKButtonText)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = title;
            dialog.Content = content;
            dialog.CloseButtonText = OKButtonText;
            dialog.ShowAsync();
        }
    }
}
