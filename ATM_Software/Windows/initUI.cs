using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Software.Windows
{
    internal class initUI
    {
        public void init()
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            login.ShowActivated = true;
        }
    }
}
