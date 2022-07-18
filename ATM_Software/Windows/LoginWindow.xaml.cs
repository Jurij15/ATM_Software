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
using System.IO;
using ATM_Software.Cores;

namespace ATM_Software.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public static string CurrentAcc { get; set; }
        public LoginWindow()
        {
            InitializeComponent();
            Logger.LogMessage("UI", "Loading Login...");
            Logger.LogMessage("UI", "UI Loaded");

            NewsBox.Text = File.ReadAllText(Locations.NewsFile);
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginSystem.LoginV2(NumberBox.Text, PINBox.Text);
        }
    }
}
