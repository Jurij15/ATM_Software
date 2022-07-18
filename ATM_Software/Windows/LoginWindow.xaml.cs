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
            LoginSystem.Login(NumberBox.Text, PINBox.Text);
            /*
            var numbers = new List<string> {
                File.ReadAllText(Locations.Account1Number),
                File.ReadAllText(Locations.Account2Number),
                File.ReadAllText(Locations.Account3Number),
                File.ReadAllText(Locations.Account4Number)
            };
            var pins = new List<string>{
                Locations.Account1PIN,
                Locations.Account2PIN,
                Locations.Account3PIN,
                Locations.Account4PIN
            };
            foreach(var number in numbers)
            {
                if (NumberBox.Text == number)
                {
                    if (NumberBox.Text == number)
                    {
                        //break;
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please check number and try again!");
                    Logger.LogError("UI", "Incorrect Number");
                    //continue;
                    //Logger.LogError("UI", "Incorrect Number");
                }
            }
            */
        }
    }
}
