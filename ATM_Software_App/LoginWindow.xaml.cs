#define showMainWindowAnywayTest
#undef showMainWindowAnywayTest
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
using System.Runtime.InteropServices;
using ATM_Software.Common.Cores;
using ATM_Software.Common;
using System.IO;
using ATM_Software.Common.Functions;
using ATM_Software.Common.Dialogs;

namespace ATM_Software_App
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        public LoginWindow()
        {
            InitializeComponent();
            AllocConsole();
            Logger.LogSuccess("UI", "Login Loaded!");
            Logger.LogSuccess("Console", "Console Loaded!");
            NewsBox.Text = File.ReadAllText(Locations.NewsFile);
            Logger.LogSuccess("Login", "News Loaded!");
#if showMainWindowAnywayTest
            MainWindow main = new MainWindow();
            main.Show();
#endif
        }
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginSystem.LoginV2(NumberBox.Text, PINBox.Text))
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Hide();
            }
            else
            {
                ErrorContentDialog.ShowDialog("Error", "Incorrect Creditentials! Please try again!");
            }
        }
    }
}
