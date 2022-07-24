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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using ATM_Software.Common;
using ATM_Software.Common.Cores;
using ATM_Software.Common.Dialogs;
using ATM_Software.Common.Functions;
using System.IO;

namespace ATM_Software_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public void ShowDepositContent()
        {
            AmountBox.Visibility = Visibility.Visible;
            UniversalBtn.Visibility = Visibility.Visible;
            UniversalBtn.Content = "Deposit";
        }
        public void ShowWithdrawalContent()
        {
            AmountBox.Visibility = Visibility.Visible;
            UniversalBtn.Visibility = Visibility.Visible;
            UniversalBtn.Content = "Deposit";
        }
        public void HideDynamicContent()
        {
            AmountBox.Visibility = Visibility.Collapsed;
            UniversalBtn.Visibility = Visibility.Collapsed;
        }
        public void GetRequiredAccountDetails()
        {
            if (AccountGeneralFunctions.GetCurrentAccountName(AccountGeneralFunctions.GetCurrentAccount()) != null)
            {
                AccOwnerBox.Text = AccountGeneralFunctions.GetCurrentAccountName(AccountGeneralFunctions.GetCurrentAccount());
                if (AccountGeneralFunctions.GetAccountMoneyStat(AccountGeneralFunctions.GetCurrentAccount()) != null)
                {
                    AccMoneyBox.Text = AccountGeneralFunctions.GetAccountMoneyStat(AccountGeneralFunctions.GetCurrentAccount());
                }
                else
                {
                    Logger.LogError("Main", "Error loading account details!");
                    ErrorContentDialog.ShowDialog("Error", "An error occured, please restart the application!");
                }
            }
            else
            {
                Logger.LogError("Main", "Error loading account details!");
                ErrorContentDialog.ShowDialog("Error", "An error occured, please restart the application!");
            }
            Logger.LogSuccess("Main", "Account details loaded!");
        }
        public void RefreshStat()
        {
            //this is almost the same as getreqaccdetails, just a different name and log
            if (AccountGeneralFunctions.GetCurrentAccountName(AccountGeneralFunctions.GetCurrentAccount()) != null)
            {
                AccOwnerBox.Text = AccountGeneralFunctions.GetCurrentAccountName(AccountGeneralFunctions.GetCurrentAccount());
                if (AccountGeneralFunctions.GetAccountMoneyStat(AccountGeneralFunctions.GetCurrentAccount()) != null)
                {
                    AccMoneyBox.Text = AccountGeneralFunctions.GetAccountMoneyStat(AccountGeneralFunctions.GetCurrentAccount());
                }
                else
                {
                    Logger.LogError("Main", "Error refreshing account details!");
                    ErrorContentDialog.ShowDialog("Error", "An error occured, please restart the application!");
                }
            }
            else
            {
                Logger.LogError("Main", "Error refreshing account details!");
                ErrorContentDialog.ShowDialog("Error", "An error occured, please restart the application!");
            }
            Logger.LogSuccess("Main", "Account details loaded!");
        }
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        public MainWindow()
        {
            InitializeComponent();
            Logger.LogSuccess("UI", "Main Loaded!");            
            //first, we check if that is null, if it is, app exits
            AccountGeneralFunctions.CheckCurrentAccountConfig();
            //AllocConsole();
            GetRequiredAccountDetails();
            HideDynamicContent();
            if (AccountGeneralFunctions.CheckAccountValid(configs.CurrentAccount))
            {
                InvalidMesage.Visibility = Visibility.Hidden;
                //account is valid, no worries there
            }
            else if (!AccountGeneralFunctions.CheckAccountValid(configs.CurrentAccount))
            {
                Logger.LogWarning("Account", "Account is invalid!");
                InvalidMesage.Visibility = Visibility.Visible;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void DepositBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowDepositContent();
        }

        private void WithdrawalBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowWithdrawalContent();
        }

        private void UniversalBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UniversalBtn.Content == "Deposit")
            {
                if (AmountBox.Text == "")
                {
                    ErrorContentDialog.ShowDialog("Error", "Amount can't be empty!");
                }
                else if (AmountBox.Text != "")
                {
                    AccountMoneyFunctions.DepositMoney(configs.CurrentAccount, Int32.Parse(AmountBox.Text));
                    RefreshStat();
                    HideDynamicContent();
                }
            }
            else if (UniversalBtn.Content == "Withdrawal")
            {
                if (AmountBox.Text == "")
                {
                    ErrorContentDialog.ShowDialog("Error", "Amount can't be empty!");
                }
                else if (AmountBox.Text != "")
                {
                    AccountMoneyFunctions.WithDrawalMoney(configs.CurrentAccount, Int32.Parse(AmountBox.Text));
                    RefreshStat();
                    HideDynamicContent();
                }
            }
        }
    }
}
