using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Quice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // start loginsplash screen
            LoginSplashScreen aLoginSplashScreen = new LoginSplashScreen();
            // show it
            aLoginSplashScreen.ShowDialog();
            Application.Run(new MainIQuiceForm());
        }
    }
}
