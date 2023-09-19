using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Hecop_Security
{
    internal class App_Core:ApplicationContext
    {
        public App_Core() {

            MainForm = Form1.Instance;
            StartClamAV();
            var v = new Thread((() =>
            {
              
                while (true)
                {

                    TimerCallback(null);

                    Thread.Sleep(2000);
                }
            }));
            v.IsBackground = true;
            v.Start();


        }

        object j = new object();
   

        private  void TimerCallback(Object o)
        {

            if (HomeUI.Instance.InvokeRequired)
            {
                if (HomeUI.Instance.Controls.Contains(LoadingSecurity.Instance))
                    HomeUI.Instance.Invoke((Action)(() => HomeUI.Instance.Controls.Remove(LoadingSecurity.Instance)));

            }
            if (UpdateUI.Instance.label4.InvokeRequired)
                UpdateUI.Instance.label4.Invoke((Action)(() =>
                UpdateUI.Instance.label4.Text = "Trạng thái: Đã cập nhật\n" + HecopManager.GetDataBaseVersion()));

            if (HomeUI.Instance.label2.InvokeRequired)
            {
                HomeUI.Instance.label2.Invoke((Action)(() =>
              HomeUI.Instance.label2.Text = HecopManager.GetDataBaseVersion()));
            }
        }

     

        public static void StartClamAV()
        {
            try
            {
                bool a = false;

                foreach (Process pd in Process.GetProcesses())
                {
                    //System.IO.File.AppendAllLines("C:\\a.txt", new string[] { pd.ProcessName});
                    if (pd.ProcessName == "clamd")
                        a = true;

                }

                //foreach (Process s in Process.GetProcessesByName("clamd.exe")) s.Kill();

                

                if (a == false)
                {
                    Process prc = new Process();
                    
                    prc.StartInfo = new ProcessStartInfo();
                    prc.StartInfo.FileName = Application.StartupPath + "\\ClamAV\\" + (Environment.Is64BitOperatingSystem==false ? "x86" : "x64") + "\\clamd.exe";
                    prc.StartInfo.UseShellExecute = false;
                    prc.StartInfo.RedirectStandardOutput = true;

                    prc.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                    prc.StartInfo.RedirectStandardOutput = true;
                    prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    prc.StartInfo.CreateNoWindow = true;


                    prc.Start();
                }

               
            }
            catch { }

        }


        public static void StopClamAV()
        {
            try
            {
                foreach (Process pd in Process.GetProcesses())
                {
                    if (pd.ProcessName == "clamd")
                        pd.Kill();

                }
            }
            catch
            {

            }
        }

       
    }
}
