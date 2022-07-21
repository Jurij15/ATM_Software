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
        public void RefreshStat()
        {

        }
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        public MainWindow()
        {
            InitializeComponent();
            //first, we check if that is null, if it is, app exits
            AccountGeneralFunctions.CheckCurrentAccountConfig();
            //AllocConsole();
        }
    }
}
