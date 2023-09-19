using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hecop_Security
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using(Mutex mu = new Mutex(true, Application.ProductName, out bool cre)) {
                if(cre==true)
                {
                    Application.Run(new App_Core());
                    //Application.Run(new Form1());
                }    

            }

          
            Application.ApplicationExit += Application_ApplicationExit;

            Application.ThreadExit += Application_ThreadExit;
        }

        

        private static void Application_ThreadExit(object sender, EventArgs e)
        {
            App_Core.StopClamAV();
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            App_Core.StopClamAV();
        }
    }
}
