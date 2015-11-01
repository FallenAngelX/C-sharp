using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Quice
{
    public partial class LoginSplashScreen : Form
    {
        public LoginSplashScreen()
        {
            InitializeComponent();
        }

        private void LoginCancelbutton_Click(object sender, EventArgs e)
        {
            //Close the program
            this.Close();
        }

        private void LoginClearbutton_Click(object sender, EventArgs e)
        {
            // just clear Input text boxes
        }
    }
}
